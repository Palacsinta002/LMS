import React, { useState } from 'react';
import axios from "axios";
import FormCard from '../Components/FormCard';
import "../Styles/Verify.css";
import { useLocation, useNavigate } from 'react-router-dom';
import usePreviousLocation from '../Hooks/usePreviousLocation';

export default function Verify() {
  const [code, setCode] = useState("");
  const [error, setError] = useState("");
  const [loading, setLoading] = useState(false);
  const navigate = useNavigate();
  const location = useLocation();
  const previousLocation = usePreviousLocation(location);
  const endpoint = previousLocation?.pathname === "/register" ? "/api/finalize-registration" : "/api/verify-account";
  console.log("Endpoint:", endpoint);

  async function HandleSubmit(event) {
    event.preventDefault();
    setLoading(true);
    setError("");

    try {
      const response = await axios.post(
        `${endpoint}`,
        {
          verificationCode: code
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
    <div className="verify">
      <div className="verify-header">
        <h1 className="verify-top">Welcome to</h1>
        <h2 className="verify-bottom">Library Management System</h2>
      </div>
      <div className="verify-container">
        <i className="fa fa-check-circle"></i>
        <h1>Verify Account</h1>
        <form onSubmit={HandleSubmit}>
          <div className="verify-card-holder">
            <FormCard className="verify-card" label="Verification code" type="number" onChange={(e) => setCode(e.target.value)} />
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