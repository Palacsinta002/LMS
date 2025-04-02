import React, { useContext, useState, useEffect } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import "../Pages/Dashboard.css";
import { jwtDecode } from 'jwt-decode';
import { AuthContext } from '../Auth/AuthProvider';

export default function DashboardHeader() {
  const { logout } = useContext(AuthContext);
  const navigate = useNavigate();
  const [user, setUser] = useState(null);

  useEffect(() => {
    const token = sessionStorage.getItem('token');
    if (token) {
      const decodedToken = jwtDecode(token);
      setUser(decodedToken["sub"]);
    } else {
      navigate('/login');
    }
  }, [navigate, logout]);

  return (
    <>
      <div className="dashboardHeader">
        <Link to="/"><h1 className="headerLink">LMS</h1></Link>
        {<h1 className="headerH1">Hi, {user}</h1>}
        <Link className="dashboardHeaderButton" onClick={logout}>Logout</Link>
      </div>

      <nav className="navigation">
        <Link className="link" to="/dashboard/borrowings">Borrowings</Link>
        <Link className="link" to="/dashboard/reservations">Reservations</Link>
        <Link className="link" to="/dashboard/dashboard">Dashboard</Link>
        <Link className="link" to="/dashboard/profile">Profile</Link>
      </nav>
      <hr className="hr" />
    </>
  );
}
