import React, { useEffect, useState } from 'react'
import axios from "axios"
import { Link, useNavigate } from 'react-router-dom'
import "./Login.css"

export default function Login() {
  axios.defaults.withCredentials = true;
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");
  const [showPassword, setShowPassword] = useState(false);
  const navigate = useNavigate();

  async function HandleSubmit(event){
    event.preventDefault();
    try{
      const response = await axios.post("http://localhost/LMS/Website/PHP/RealProject/users/userapi.php/login", {username, password})
      localStorage.setItem("token", response.data.token);
      navigate("/dashboard");
    }
    catch(error){
      console.error(error);
      setError("Not authorized!")
    }
  }
  return (
    <div className="login">
      <h1 className="login-header">Library Management System</h1>
      <div className="login-card">
        <i className="fa fa-user"></i>
        <h1>Login</h1>
        <form action="">
          <label>Username</label>
          <input type="text" value={username} onChange={(e) => setUsername(e.target.value)}/>
          <label>Password</label>
          <input type="password" value={password} onChange={(e) => setPassword(e.target.value)}/>
          <span><Link className="link1">Forgot your password?</Link></span>
          <input type="submit" onSubmit={HandleSubmit} value="Sign in" />
          <span><Link to="/register" className="link2">Create new account?</Link></span>
        </form>
      </div>
    </div>
  )
}
