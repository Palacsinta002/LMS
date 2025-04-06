import React, { useState } from 'react'
import axios from "axios"
import { Link, useNavigate } from 'react-router-dom'
import "../Styles/Login.css"
import { setAuthToken } from '../Auth/setAuthToken';

export default function Login() {
  axios.defaults.withCredentials = true;
  const [email, setEmail] = useState("");
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");
  const [showPassword, setShowPassword] = useState(false);
  const [loading, setLoading] = useState(false);
  const navigate = useNavigate();


  async function HandleSubmit(event) {
    event.preventDefault();
    setLoading(true);
    try {
      const response = await axios.post("api/login",
        { username: username, password: password },
        {
          headers: {
            "method": "POST",
            "Content-Type": "application/json",
          }
        });

        console.log(response.data)
      if (response.data.Token) {
        setAuthToken(response.data.Token);
        console.log(response.data.Token)
        sessionStorage.setItem("token", response.data.Token);
        navigate("/dashboard");
      }
      else{
        navigate("/login")
      }
    } catch (error) {
      console.error("Login Error:", error);
  
      if (error.response && error.response.data && error.response.data.error) {
        console.log(error.response.data.error);
        setError(error.response.data.error || "Login failed");
      } else {
        setError("Network error");
      }
    } finally {
      setLoading(false);
    }
  }
  return (
    <div className="login">
      <Link to="/" className="back-to-home">Back to Home</Link>
      <h1 className="login-header">Library Management System</h1>
      <div className="login-card">
        <i className="fa fa-user"></i>
        <h1>Finalize Registration</h1>
        <form onSubmit={HandleSubmit}>
          <label>Email</label>
          <input type="email" value={email} onChange={(e) => setEmail(e.target.value)} />
          <label>Username</label>
          <input type="text" value={username} onChange={(e) => setUsername(e.target.value)} />
          <label>Password</label>
          <div className="login-password-input">
            <input
              type={showPassword ? "text" : "password"}
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            />
            <button
              type="button"
              onClick={() => setShowPassword(!showPassword)}
              className="login-toggle-password"
            >
              {showPassword ? "Hide" : "Show"}
            </button>
          </div>
          {error && <p className="error-message">{error}</p>}
          <input type="submit" value={loading ? "Finalizing..." : "Finalize"} disabled={loading} />
          <span><Link to="/login" className="link2">I already have an account!</Link></span>
        </form>
      </div>
    </div>
  )
}