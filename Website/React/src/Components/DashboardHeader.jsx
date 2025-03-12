import React, { useContext, useEffect, useState } from 'react';
import { jwtDecode } from "jwt-decode";
import "../Pages/Dashboard.css";
import { Link } from 'react-router-dom';

export default function DashboardHeader() {
    const token = sessionStorage.getItem("token");
    const decoded = jwtDecode(token);
    const name = decoded["sub"];
    return (
        <>
            <div className="dashboardHeader">
                <Link to="/home"><h1 className="headerLink">LMS</h1></Link>
                <h1 className="headerH1">Hi, {name}</h1>
            </div>

            <nav className="navigation">
                <Link className="link" to="/dashboard/borrowings">Borrowings</Link>
                <Link className="link" to="/dashboard/reservations">Reservations</Link>
                <Link className="link" to="/dashboard/charts">Charts</Link>
                <Link className="link" to="/dashboard/profile">Profile</Link>
            </nav>
            <hr className="hr" />
        </>
    )
}