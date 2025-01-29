import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import FormCard from '../Components/FormCard';
import "./Verify.css";

export default function Verify() {
    const [code, setCode] = useState("");
    const [error, setError  ] = useState("");

    async function HandleSubmit(event) {
        event.preventDefault();
      
        try {
          const response = await axios.post(
            "/api/users/userapi.php/verify",
            {
              verifyCode: code
            },
            {
              headers: { "Content-Type": "application/json" },
            }
          );
      
          console.log(response.data);
          if(response.data.success){
            navigate("/verify");
          }
          else{
            setError(response.data.message);
            console.log(response)
          }
        } catch (error) {
          console.error("Registery error:", error);
          setError("Registery error!");
        }
      }

  return (
        <div className="verify">
      <div className="verify-header">
        <h1 className="verify-top">Welcome to</h1>
        <h2 className="verify-bottom">Library Management System</h2>
      </div>
      <div className="verify-container">
      <i className="fa fa-check-circle"></i>
        <h1>Verify Account</h1>
        <form >
          <div className="verify-card-holder">
            <FormCard className="verify-card" label="Verification code" type="number" onChange={(e) => setCode(e.target.value)}/>
          </div>
          <center>
            <div className="actions">
              <input type="submit" value="Verify"/>
            </div>
          </center>
        </form>
      </div>
    </div>
  )
}
