import React, { useState } from 'react'
import { Link, useNavigate } from 'react-router-dom'
import "./Register.css"
import FormCard from '../Components/FormCard'
import axios from 'axios'

export default function Register() {
  const [email, setEmail] = useState("");
  const [username, setUsername] = useState("");
  const [firstname, setFirstname] = useState("");
  const [lastname, setLastname] = useState("");
  const [password, setPassword] = useState("");
  const [passwordAgain, setPasswordAgain] = useState("");
  const [showPassword, setShowPassword] = useState(false);
  const [error, setError] = useState("");
  const [loading, setLoading] = useState(false);
  const navigate = useNavigate();

  async function HandleSubmit(event) {
    event.preventDefault();
    setLoading(true);
    setError("");

    if (password !== passwordAgain) {
      setError("Passwords do not match!");
      setLoading(false);
      return;
    }

    try {
      const response = await axios.post(
        "/api/users/userapi.php/register",
        {
          username: username,
          password: password,
          email: email,
          firstname: firstname,
          lastname: lastname,
          passwordAgain: passwordAgain
        },
        {
          headers: { "Content-Type": "application/json" },
        }
      );
      console.log(response.data);
      if (response.data.Success) {
        navigate("/verify");
      } else {
        setError(response.data.message || "Registration failed!");
      }
    } catch (error) {
      console.error("Registration error:", error);
      setError("Registration error!");
    } finally {
      setLoading(false);
    }
  }

  return (
    <div className="register">
      <Link to="/" className="back-to-home">Back to Home</Link>
      <div className="register-header">
        <h1 className="register-top">Welcome to</h1>
        <h2 className="register-bottom">Library Management System</h2>
      </div>
      <div className="register-container">
        <i className="fa fa-user"></i>
        <h1>Register Account</h1>
        <form onSubmit={HandleSubmit}>
          <div className="register-card-holder">
            <FormCard className="register-card" label="Email" type="email" onChange={(e) => setEmail(e.target.value)} />
            <FormCard className="register-card" label="Username" type="text" onChange={(e) => setUsername(e.target.value)} />
            <FormCard className="register-card" label="First name" type="text" onChange={(e) => setFirstname(e.target.value)} />
            <FormCard className="register-card" label="Last name" type="text" onChange={(e) => setLastname(e.target.value)} />
            <FormCard className="register-card" label="Password" type={showPassword ? "text" : "password"} onChange={(e) => setPassword(e.target.value)} />
            <FormCard className="register-card" label="Password again" type={showPassword ? "text" : "password"} onChange={(e) => setPasswordAgain(e.target.value)} />
            <button type="button" onClick={() => setShowPassword(!showPassword)} className="toggle-password">
              {showPassword ? "Hide" : "Show"} Password
            </button>
          </div>
          {error && <p className="error-message">{error}</p>}
          <center>
            <div className="actions">
              <input type="submit" value={loading ? "Signing up..." : "Sign up"} disabled={loading} />
              {loading && <div className="spinner"></div>}
              <span><Link to="/login" className="link2">I already have an account!</Link></span>
            </div>
          </center>
        </form>
      </div>
    </div>
  )
}