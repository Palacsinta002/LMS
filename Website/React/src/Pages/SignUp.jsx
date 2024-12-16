import React from 'react'
import { Link } from 'react-router-dom'
import "./SignUp.css"

export default function SignUp() {
  return (
    <div className="register">
      <h1 className="register-header">Library Management System</h1>
      <div className="register-container">
        <i className="fa fa-user"></i>
        <h1>Register Account</h1>
        <form action="">
          <div className="register-card-holder">
            <div className="register-card">
              <label>Email</label>
              <input type="email" />
            </div>

            <div className="register-card">
              <label>Username</label>
              <input type="text" />
            </div>

            <div className="register-card">
              <label>First name</label>
              <input type="text" />
            </div>

            <div className="register-card">
              <label>Last name</label>
              <input type="text" />
            </div>

            <div className="register-card">
              <label>Password</label>
              <input type="password" />
            </div>

            <div className="register-card">
              <label>Password again</label>
              <input type="password" />
            </div>
          </div>
          
          <div className="actions">
            <input type="submit" value="Sign in" />
            <span><Link className="link2">I already have an account!</Link></span>
          </div>
        </form>
      </div>
    </div>
  )
}
