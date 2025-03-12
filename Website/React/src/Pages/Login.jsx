import React, { useState } from 'react'
import axios from "axios"
import { Link, useNavigate } from 'react-router-dom'
import "./Login.css"
import { setAuthToken } from '../Hooks/setAuthToken';
import { jwtDecode } from 'jwt-decode';

export default function Login() {
  axios.defaults.withCredentials = true;
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
      const response = await axios.post(
        "/api/login",
        { username: username, password: password },
        {
          headers: {
            "method": "POST",
            "Content-Type": "application/json",
          }
        });

        const token = JSON.stringify(response.data.token);

      if (token) {
        setAuthToken(token);
        sessionStorage.setItem("token", token);
        navigate("/dashboard");
      }
    } catch (error) {
      console.error(error);

      if (error.response) {
        console.error(response.data.error);
        setError(response.data.error || "Login failed");
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
        <h1>Login</h1>
        <form onSubmit={HandleSubmit}>
          <label>Username</label>
          <input type="text" value={username} onChange={(e) => setUsername(e.target.value)} />
          <label>Password</label>
          <div className="password-input">
            <input
              type={showPassword ? "text" : "password"}
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            />
            <button
              type="button"
              onClick={() => setShowPassword(!showPassword)}
              className="toggle-password"
            >
              {showPassword ? "Hide" : "Show"}
            </button>
          </div>
          {error && <p className="error-message">{error}</p>}
          <span><Link className="link1">Forgot your password?</Link></span>
          <input type="submit" value="Sign in" disabled={loading} />
          <span><Link to="/register" className="link2">Create new account?</Link></span>
        </form>
      </div>
    </div>
  )
}