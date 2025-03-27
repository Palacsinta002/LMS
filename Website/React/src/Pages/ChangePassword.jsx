import React, { useEffect, useState } from 'react';
import axios from "axios";
import FormCard from '../Components/FormCard';
import "./register.css";
import { useNavigate } from 'react-router-dom';

export default function ChangePassword() {
    const [password, setPassword] = useState("");
    const [passwordAgain, setPasswordAgain] = useState("");
    const [error, setError] = useState("");
    const [loading, setLoading] = useState(false);
    const [token, setToken] = useState("");
    const navigate = useNavigate();

    useEffect(() => {
        const url = window.location.href;
        console.log(url)
        const emailToken = url.split("/").pop();
        setToken(emailToken);
        console.log(emailToken)
    }, [])

    async function HandleSubmit(event) {
        event.preventDefault();
        setLoading(true);
        setError("");

        try {
            const response = await axios.put(
                "/api/change-password",
                {
                    password: password,
                    passwordAgain: passwordAgain
                },
                {
                    headers: { "Content-Type": "application/json", "Authorization": `Bearer ${token}` },
                }
            );

            console.log(response.data);
            if (response.data.Success) {
                navigate("/login");
            } else {
                setError(response.data.message || "Verification failed!");
            }
        } catch (error) {
            console.error("Email error:", error);
            setError("Email error!");
        } finally {
            setLoading(false);
        }
    }

    return (
        <div className="verify">
            <div className="verify-header">
                <h1 className="verify-top">Welcome back to</h1>
                <h2 className="verify-bottom">Library Management System</h2>
            </div>
            <div className="verify-container">
                <i className="fa fa-check-circle"></i>
                <h1>Reset Password</h1>
                <form onSubmit={HandleSubmit}>
                    <div className="verify-card-holder">
                        <FormCard className="verify-card" label="New Password" type="password" onChange={(e) => setPassword(e.target.value)} />
                        <FormCard className="verify-card" label="New Password Again" type="password" onChange={(e) => setPasswordAgain(e.target.value)} />
                    </div>
                    {error && <p className="error-message">{error}</p>}
                    <center>
                        <div className="actions">
                            <input type="submit" value="Reset Password" disabled={loading} />
                        </div>
                    </center>
                </form>
            </div>
        </div>
    )
}