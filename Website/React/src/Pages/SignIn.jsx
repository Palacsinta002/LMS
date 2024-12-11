import React from 'react'
import Login from '../Components/Login'
import "../index.css"

export default function SignIn() {
  return (
    <div className="login">
        <h1 className="login-header">Library Management System</h1>
        <Login />
    </div>
  )
}
