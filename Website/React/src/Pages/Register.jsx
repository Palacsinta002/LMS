import React, { useState } from 'react'
import { Link, useNavigate } from 'react-router-dom'
import "../Styles/Register.css"
import axios from 'axios'

export default function Register() {
  const [email, setEmail] = useState("");
  const [username, setUsername] = useState("");
  const [firstname, setFirstname] = useState("");
  const [lastname, setLastname] = useState("");
  const [password, setPassword] = useState("");
  const [showPassword, setShowPassword] = useState(false);
  const [dateOfBirth, setDateOfBirth] = useState("");
  const [address, setAddress] = useState("");
  const [error, setError] = useState("");
  const [loading, setLoading] = useState(false);
  const navigate = useNavigate();

  async function HandleSubmit(event) {
    event.preventDefault();
    setLoading(true);
    setError("");

    try {
      const response = await axios.post(
        "/api/register",
        {
          username: username,
          password: password,
          email: email,
          firstname: firstname,
          lastname: lastname,
          dateOfBirth: dateOfBirth
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
        <i className="fa fa-user register-icon"></i>
        <h1>Register Account</h1>
        <form onSubmit={HandleSubmit}>
          <div className="register-card-holder">

            <div className="register-card">
              <label htmlFor="firstname">First name</label>
              <input type="text" onChange={(e) => setFirstname(e.target.value)} required />
            </div>

            <div className="register-card">
              <label htmlFor="lastname">Last name</label>
              <input type="text" onChange={(e) => setLastname(e.target.value)} required />
            </div>

            <div className="register-card">
              <label htmlFor="email">Email</label>
              <input type="email" onChange={(e) => setEmail(e.target.value)} required />
            </div>

            <div className="register-card">
              <label htmlFor="username">Username</label>
              <input type="text" onChange={(e) => setUsername(e.target.value)} required />
            </div>

            <div className="register-card">
              <label htmlFor="passwordAgain">Password</label>
              <div className="register-password-input">
                <input type={showPassword ? "text" : "password"} onChange={(e) => setPassword(e.target.value)} required />
                <button type="button" onClick={() => setShowPassword(!showPassword)} className="register-toggle-password">
                <i className={`fa ${showPassword ? "fa-eye-slash" : "fa-eye"}`}></i>
                </button>
              </div>
            </div>

            <div className="register-card">
              <label htmlFor="dateOfBirth">Date of Birth</label>
              <input type="date" onChange={(e) => setDateOfBirth(e.target.value)} required />
            </div>

            <div className="register-card">
              <label htmlFor="dateOfBirth">Address</label>
              <input type="string" onChange={(e) => setAddress(e.target.value)} required />
            </div>

          </div>
          {error && <p className="error-message">{error}</p>}
          <center>
            <div className="actions">
              <input type="submit" value={loading ? "Registering..." : "Register"} disabled={loading} />
              {loading && <div className="spinner"></div>}
              <span><Link to="/login" className="link2">I already have an account!</Link></span>
              <span><Link to="/finalize-registration" className="link2">Finalize registration!</Link></span>
            </div>
          </center>
        </form>
      </div>
    </div>
  )
}