import React from 'react'
import "../index.css"
import { Link } from 'react-router-dom'

export default function Header({ currentPage, handlePage }) {
  const hidden = currentPage === "home" ? "" : "hidden";
  console.log(currentPage)

  return (
    <header className={hidden}>
      <Link to="/"><h1 className="title">LMS</h1></Link>
      <div className="logReg">
        <Link to="/SignUp" className="signup" onClick={() => handlePage("SignUp")}>Sign Up</Link>
        <Link to="/SignIn" className="signin" onClick={() => handlePage("SigIn")}>Sign In</Link>
      </div>
    </header>
  )
}