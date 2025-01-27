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
        <Link to="/register" className="signup">Register</Link>
        <Link to="/login" className="signin">Login</Link>
      </div>
    </header>
  )
}