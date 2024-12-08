import React from 'react'
import "../index.css"
<<<<<<< HEAD
import { Link } from 'react-router-dom'

export default function Header({ currentPage, handlePage }) {
  const hidden = currentPage === "home" ? "hidden" : "";
  console.log(currentPage)
=======
import { Link, Outlet } from 'react-router-dom'
>>>>>>> 561256eb2facf9ad5744e47990583594e03b58e9

export default function Header(hidden, handleHidden) {
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