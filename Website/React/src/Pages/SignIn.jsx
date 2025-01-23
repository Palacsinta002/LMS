import React, { useState } from 'react'
import axios from "axios"
import { Link } from 'react-router-dom'
import "./SignIn.css"

export default function SignIn() {
  axios.defaults.withCredentials = true;
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

  const handleSubmit = async () => {
    try {
      const response = await axios.post("http://localhost/LMS/Website/PHP/realproject/users/userapi.php", {
        username,
        password
      }, {
        headers: {
          "Content-Type": "application/json"
        }
      });
      setError(response.data.message);
      console.log(response.data.message);
    } catch (error) {
      setError("Something went wrong...");
      console.error(error);
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
          <input type="text" onChange={UsernameOnChange}/>
          <label>Password</label>
          <input type="password" onChange={PasswordOnChange}/>
          <span><Link className="link1">Forgot your password?</Link></span>
          <input type="submit" onClick={handleSubmit} value="Sign in" />
          <span><Link to="/signup" className="link2">Create new account?</Link></span>
        </form>
      </div>
    </div>
  )
}
