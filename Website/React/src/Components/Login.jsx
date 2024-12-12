import React from 'react'
import { Link } from 'react-router-dom'
import "../index.css"

export default function Login() {
  return (
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
        <span><Link className="link2">Create new account?</Link></span>
      </form>
    </div>
  )
}
