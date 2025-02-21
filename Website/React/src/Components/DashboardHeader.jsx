import React, { useEffect, useState } from 'react'
import axios from 'axios';
import { Link } from 'react-router-dom';

export default function DashboardHeader() {
    /*const [name, setName] = useState();
    useEffect(() =>{
        axios.get()
    }, [])*/
    const name = "Johndoe"    
    return (
        <div>
            <h1>Hi, {name}</h1>
            <nav>
                <Link to="/">Dashboard</Link>
                <Link to="/dashboard/borrowings">Borrowings</Link>
                <Link to="/dashboard/reservations">Reservations</Link>
                <Link to="/dashboard/profile">Profile</Link>
            </nav>
        </div>
    )
}