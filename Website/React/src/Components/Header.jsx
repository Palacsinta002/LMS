import React from 'react';
import "../index.css";
import { Link, useLocation } from 'react-router-dom';

export default function Header() {
  const location = useLocation();
  const hidden = location.pathname !== "/" ? "hidden" : "";
  const isAuthorized = !!sessionStorage.getItem("token");

  function Logout() {
    sessionStorage.removeItem("token");
    window.location.href = "/";
  }

  return (
    <header className={hidden}>
      <Link to="/"><h1 className="title">LMS</h1></Link>
      <div className="logReg">
        {!isAuthorized && <Link to="/register" className="signup">Register</Link>}
        {!isAuthorized && <Link to="/login" className="signin">Login</Link>}
        {isAuthorized && <Link to="/dashboard" className="dashboard">Dashboard</Link>}
        {isAuthorized && <Link to="/" className="logout" onClick={Logout}>Logout</Link>}
      </div>
    </header>
  );
}
