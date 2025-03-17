<?php
namespace Database\Queries;
use Helper\Helper;
class UserTable extends Table{
    public static function selectByUsername ( $username ){
        $username = Helper::validateTheInput($username);
        return self::select(["users"],["id","username","password","verified"])->where(["username"],["="],[$username],["s"])->execute(true);
    }
    public static function rowExists ( $field,$operator,$value,$type ){
        $validatedField = Helper::validateTheInputArray($field);
        $validatedOperator = Helper::validateTheInputArray($operator);
        $validatedValue = Helper::validateTheInputArray($value);
        $result = self::select(["users"],["id"])
        ->where($validatedField,$validatedOperator,$validatedValue,$type)
        ->execute(true,false);

        if ($result->num_rows == 0) {
            return false;
        }
        return true;
    }

    public static function updateToVerified ( $code ){
        $validatedCode = Helper::validateTheInput($code);
        self::update("users",["verified"],["1"],["i"])->where(["verificationCode","verified"],["=","="],[$code,"0"],["s","i"])->execute(false);
        return true;
    }
    public static function insertToUser($value){
        $validatedCode = Helper::validateTheInput($value);
        self::insert("users",["email","username","password","firstname","lastname","VerificationCode","Address","RoleID"],
        [$validatedCode["email"],$validatedCode["username"],$validatedCode["password"],$validatedCode["firstname"],$validatedCode["lastname"],$validatedCode["verificationCode"],$validatedCode["address"],"3"],
        ["s","s","s","s","s","s","s","i"])->execute(false) ;
        return true;
    }
    public static function numberOfUsers (){
        return self::select(["users"],["Count(id) AS 'users'"])->execute(true);
    }
    public static function selectUserData($ID){
        return self::select(["users"],["users.email","users.username","users.firstname","users.lastname","users.lastname","users.address","Roles.Role"])
        ->innerJoin("Roles",["users.RoleID"],["="],["Roles.ID"])
        ->where(["users.ID"],["="],[$ID],["i"])->execute(true);
    }

    
}

?>