import React, { useState } from 'react';
import axios from "axios";
import FormCard from '../Components/FormCard';
import "./register.css";
import { useNavigate } from 'react-router-dom';

export default function ForgotPassword() {
  const [email, setEmail] = useState("");
  const [error, setError] = useState("");
  const [loading, setLoading] = useState(false);
  const [emailSent, setEmailSent] = useState(false)
  const navigate = useNavigate();

  async function HandleSubmit(event) {
    event.preventDefault();
    setLoading(true);
    setError("");

    try {
      const response = await axios.post(
        "/api/forgot-password",
        {
          email: email
        },
        {
          headers: { "Content-Type": "application/json" },
        }
      );

      console.log(response.data);
      if (response.data.Success) {
        setEmailSent(true);
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
        <form onSubmit={HandleSubmit}>

          {emailSent == false ? (
            <>
              <h1>Forgot your Password?</h1>
              <div className="verify-card-holder">
                <FormCard
                  className="verify-card"
                  label="Email"
                  type="email"
                  onChange={(e) => setEmail(e.target.value)}
                />
              </div>
              {error && <p className="error-message">{error}</p>}
              <center>
                <div className="actions">
                  <input type="submit" value="Send Email" disabled={loading} />
                </div>
              </center>
            </>
          ) : (
            <h1 className="verify-email-sent">Email sent successfully!</h1>
          )}

        </form>
      </div>
    </div>
  )
}