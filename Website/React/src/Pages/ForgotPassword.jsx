import React, { useState } from 'react';
import axios from "axios";
import FormCard from '../Components/FormCard';
import "./Verify.css";
import { useNavigate } from 'react-router-dom';

export default function ForgotPassword() {
  const [code, setCode] = useState("");
  const [error, setError] = useState("");
  const [loading, setLoading] = useState(false);
  const navigate = useNavigate();

  async function HandleSubmit(event) {
    event.preventDefault();
    setLoading(true);
    setError("");

    try {
      const response = await axios.post(
        "/api/forgot-password",
        {
          verifyCode: code
        },
        {
          headers: { "Content-Type": "application/json" },
        }
      );

      console.log(response.data);
      if (response.data.Success) {
        navigate("/login");
      } else {
        setError(response.data.message || "Verification failed!");
      }
    } catch (error) {
      console.error("Verification error:", error);
      setError("Verification error!");
    } finally {
      setLoading(false);
    }
  }

  return (
    <div className="fp">
      <div className="fp-header">
        <h1 className="fp-top">Welcome to</h1>
        <h2 className="fp-bottom">Library Management System</h2>
      </div>
      <div className="fp-container">
        <i className="fa fa-check-circle"></i>
        <h1>Forgot your Password?</h1>
        <form onSubmit={HandleSubmit}>
          <div className="fp-card-holder">
            <FormCard className="fp-card" label="Verification code" type="number" onChange={(e) => setCode(e.target.value)} />
          </div>
          {error && <p className="error-message">{error}</p>}
          <center>
            <div className="actions">
              <input type="submit" value="Verify" disabled={loading} />
            </div>
          </center>
        </form>
      </div>
    </div>
  )
}