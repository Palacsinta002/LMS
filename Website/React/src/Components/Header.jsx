import React from 'react'
import "../index.css"
import { Link, useLocation } from 'react-router-dom'

export default function Header() {
  const location = useLocation();
  const hidden = location.pathname !== "/" ? "hidden" : "";

  return (
    <header className={hidden}>
      <Link to="/"><h1 className="title">LMS</h1></Link>
      <div className="logReg">
        <Link to="/SignUp" className="signup">Sign Up</Link>
        <Link to="/SignIn" className="signin">Sign In</Link>
      </div>
    </header>
  )
}