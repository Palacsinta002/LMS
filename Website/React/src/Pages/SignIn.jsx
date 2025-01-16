import React, { useState } from 'react'
import axios from "axios"
import { Link } from 'react-router-dom'
import "./SignIn.css"

export default function SignIn() {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");
  const [showPassword, setShowPassword] = useState(false);

  function handleSubmit(event){
    event.preventDefault();
    axios
    .post("vagvolgyinas.synology.me",{
      username: username,
      password: password
    })
    .then((response) => {
      if(response.data.status === "successs"){
        sessionStorage.setItem("loggedIn", true);
        sessionStorage.setItem("userData",
          JSON.stringify(response.data.data));
        window.location.href = "/home"
      }
      else{
        setError(response.data.message);
      }
    })
  }
  return (
    <div className="login">
      <h1 className="login-header">Library Management System</h1>
      <div className="login-card">
        <i className="fa fa-user"></i>
        <h1>Login</h1>
        <form action="">
          <label>Username</label>
          <input type="text" />
          <label>Password</label>
          <input type="password" />
          <span><Link className="link1">Forgot your password?</Link></span>
          <input type="submit" value="Sign in" />
          <span><Link to="/signup" className="link2">Create new account?</Link></span>
        </form>
      </div>
    </div>
  )
}
