import React, { useEffect, useState } from 'react'
import axios from "axios"
import { Link } from 'react-router-dom'
import "./SignIn.css"

export default function SignIn() {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");
  const [showPassword, setShowPassword] = useState(false);

  function UsernameOnChange(event){
    setUsername(event.target.value);
  }
  function PasswordOnChange(event){
    setPassword(event.target.value);
  }
  useEffect(() =>{
    function handleSubmit(event){
      event.preventDefault();
      axios
      .post("vagvolgyinas.synology.me",{
        username: username,
        password: password
      })
      .then((response) => {
        if(response.data.status === "successs"){
          localStorage.setItem("loggedIn", true);
          localStorage.setItem("userData",
            JSON.stringify(response.data.data));
          window.location.href = "/home"
        }
        else{
          setError(response.data.message);
        }
      })
      .catch((error) => {
        console.error(error);
      })
    }

    handleSubmit();
  }, [])
  
  return (
    <div className="login">
      <h1 className="login-header">Library Management System</h1>
      <div className="login-card">
        <i className="fa fa-user"></i>
        <h1>Login</h1>
        <form action="">
          <label>Username</label>
          <input type="text" onChange={UsernameOnChange}/>
          <label>Password</label>
          <input type="password" onChange={PasswordOnChange}/>
          <span><Link className="link1">Forgot your password?</Link></span>
          <input type="submit" handleSubmit={handleSubmit()} value="Sign in" />
          <span><Link to="/signup" className="link2">Create new account?</Link></span>
        </form>
      </div>
    </div>
  )
}
