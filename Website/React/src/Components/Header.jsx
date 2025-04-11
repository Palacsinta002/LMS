import React, { useState, useContext } from 'react';
import { Link, useLocation } from 'react-router-dom';
import { AuthContext } from '../Auth/AuthProvider';
import "../Styles/Home.css";

export default function Header({ searchQuery, onSearch }) {
  const location = useLocation();
  const hidden = location.pathname !== "/" && location.pathname !== "/books" ? "hidden" : "";
  const hiddenSearch = location.pathname === "/" || location.pathname !== "/books" ? "hiddenSearch" : "searchBar";
  const isAuthorized = !!sessionStorage.getItem("token");

  const { logout } = useContext(AuthContext);

  return (
    <header className={hidden}>
      <Link to="/"><h1 className="title">LMS</h1></Link>
      <div className="logReg">
        {!isAuthorized && <Link to="/register" className="signup">Register</Link>}
        {!isAuthorized && <Link to="/login" className="signin">Login</Link>}
        {isAuthorized && <Link to="/" className="logout" onClick={logout}>Logout</Link>}
        {isAuthorized && <Link to="/dashboard" className="dashboard">Dashboard</Link>}
        <Link to="/books" className="books">Books</Link>
      </div>
      <input type="text" value={searchQuery || ""} onChange={(e) => onSearch(e)} placeholder="Search books..." className={hiddenSearch} />
    </header>
  );
}