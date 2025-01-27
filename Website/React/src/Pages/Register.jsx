import React, { useEffect } from 'react'
import { Link } from 'react-router-dom'
import "./Register.css"
import FormCard from '../Components/FormCard'

export default function SignUp() {
  

  return (
    <div className="register">
      <div className="register-header">
        <h1 className="register-top">Welcome to</h1>
        <h2 className="register-bottom">Library Management System</h2>
      </div>
      <div className="register-container">
        <i className="fa fa-user"></i>
        <h1>Register Account</h1>
        <form action="">
          <div className="register-card-holder">
            <FormCard className="register-card" label="Email" type="email" />
            <FormCard className="register-card" label="Username" type="text" />
            <FormCard className="register-card" label="First name" type="text" />
            <FormCard className="register-card" label="Last name" type="text" />
            <FormCard className="register-card" label="Password" type="password" />
            <FormCard className="register-card" label="Password again" type="password" />
          </div>
          <center>
            <div className="actions">
              <input type="submit" value="Sign in" />
              <span><Link to="/signin" className="link2">I already have an account!</Link></span>
            </div>
          </center>
        </form>
      </div>
    </div>
  )
}
