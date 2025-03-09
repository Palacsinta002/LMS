<<<<<<< HEAD
import React, { useState } from 'react'
import axios from "axios"
import { data, Link, useNavigate } from 'react-router-dom'
import { useSelector, useDispatch } from 'react-redux'
import { setter } from '../Hooks/TokenSlice'
import "./Login.css"
=======
import React, { useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { Link, useNavigate } from "react-router-dom";
import { loginUser } from "../Hooks/TokenSlice"; // Import the thunk
import "./Login.css";
>>>>>>> 0d84cecf17424e82cf860f3a653a686fa207ac1f

export default function Login() {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [showPassword, setShowPassword] = useState(false);
  const navigate = useNavigate();
<<<<<<< HEAD
  const token = useSelector((state) => state.token.value);
  const dispatch = useDispatch();

  async function HandleSubmit(event) {
    event.preventDefault();
    setLoading(true);
    try {
      const response = await axios.post(
        "/api/login",
        { username: username, password: password },
        {
          headers: {
            "Content-Type": "application/json",
          },
        }
      );
      const data = response.data;
      if(data.token){
        dispatch(setter(data.token));
        sessionStorage.setItem("token", data.token);
        navigate("/dashboard");
      }
      console.log(response);
    } catch (error) {
      console.error(error);
  
      if (error.response) {
        console.error(error.response.data.error);
        setError(error.response.data.error || "Login failed");
      } else {
        setError("Network error");
      }
    } finally {
      setLoading(false);
=======
  const dispatch = useDispatch();
  
  const { loading, error, isAuthenticated } = useSelector((state) => state.auth);

  async function HandleSubmit(event) {
    event.preventDefault();
    
    const result = await dispatch(loginUser({ username, password }));

    // Check if login was successful
    if (loginUser.fulfilled.match(result)) {
      navigate("/dashboard");
>>>>>>> 0d84cecf17424e82cf860f3a653a686fa207ac1f
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

          <span><Link to="/forgot-password" className="link1">Forgot your password?</Link></span>
          <input type="submit" value={loading ? "Signing in..." : "Sign in"} disabled={loading} />
          <span><Link to="/register" className="link2">Create new account?</Link></span>
        </form>
      </div>
    </div>
  );
}
