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
                <Link to="/borrowings">Borrowings</Link>
                <Link to="/reservations">Reservations</Link>
                <Link to="/profile">Profile</Link>
            </nav>
        </div>
    )
}