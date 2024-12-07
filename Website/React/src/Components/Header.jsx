import React from 'react'
import "../index.css"
import { Link, Outlet } from 'react-router-dom'

export default function Header(hidden, handleHidden) {
  return (
    <header className={hidden}>
      <Link to="/"><h1 className="title">LMS</h1></Link>
      <div className="logReg">
        <Link to="/SignUp" className="signup" onClick={handleHidden}>Sign Up</Link>
        <Link to="/SignIn" className="signin" onClick={handleHidden}>Sign In</Link>
      </div>
      <Outlet />
    </header>
  )
}