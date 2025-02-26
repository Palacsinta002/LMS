import React, { useEffect, useState } from 'react'
import axios from 'axios';
import "../Pages/Dashboard.css";
import { Link } from 'react-router-dom';

export default function DashboardHeader() {
    /*const [name, setName] = useState();
    useEffect(() =>{
        axios.get()
    }, [])*/
    const name = "Johndoe"
    return (
        <>
            <div className="dashboardHeader">
                <Link to="/"><h1 className="headerLink">LMS</h1></Link>
                <h1 className="headerH1">Hi, {name}</h1>
            </div>

            <nav className="navigation">
                <Link className="link" to="/dashboard/borrowings">Borrowings</Link>
                <Link className="link" to="/dashboard/reservations">Reservations</Link>
                <Link className="link" to="/dashboard/charts">Charts</Link>
                <Link className="link" to="/dashboard/profile">Profile</Link>
            </nav>
        </>
    )
}