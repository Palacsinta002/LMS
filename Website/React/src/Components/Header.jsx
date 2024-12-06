import React from 'react'
import "../index.css"

export default function Header() {
  return (
    <header className="header">
      <h1 className="title">LMS</h1>
      <div className="logReg">
        <a href="" className="signup">Sign Up</a>
        <a href="" className="signin">Sign In</a>
      </div>
    </header>
  )
}
