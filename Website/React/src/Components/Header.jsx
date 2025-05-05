import React, { useContext } from 'react';
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
      <Link to="/" className="title">LMS</Link>

      <div className={hiddenSearch}>
        <input
          type="text"
          value={searchQuery || ""}
          onChange={(e) => onSearch(e)}
          placeholder="Search books..."
        />
      </div>

      <div className="logReg">
      <Link to="/books" className="nav-button books">Books</Link>
        {!isAuthorized && (
          <>
            <Link to="/register" className="nav-button signup">Register</Link>
            <Link to="/login" className="nav-button signin">Login</Link>
          </>
        )}
        {isAuthorized && (
          <>
            <Link to="/dashboard" className="nav-button dashboard">Dashboard</Link>
            <Link to="/" className="nav-button logout" onClick={logout}>Logout</Link>
          </>
        )}
      </div>
    </header>
  );
}