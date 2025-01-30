import React, { useState } from 'react';
import axios from "axios";
import FormCard from '../Components/FormCard';
import "./Verify.css";
import { useNavigate } from 'react-router-dom';

export default function Verify() {
    const [code, setCode] = useState("");
    const [error, setError  ] = useState("");
    const navigate = useNavigate();

    async function HandleSubmit(event) {
        event.preventDefault();
      
        try {
          const response = await axios.post(
            "/api/users/userapi.php/verify",
            {
              verifyCode: code
            },
            {
              headers: { "Content-Type": "application/json" },
            }
          );
      
          console.log(response.data);
          if(response.data.Success){
            navigate("/");
          }
          else{
            setError(response.data.message);
            console.log(response)
          }
        } catch (error) {
          console.error("Verification error:", error);
          setError("Verification error!");
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
            <FormCard className="verify-card" label="Verification code" type="number" onChange={(e) => setCode(e.target.value)}/>
          </div>
          <center>
            <div className="actions">
              <input type="submit" value="Verify"/>
            </div>
          </center>
        </form>
      </div>
    </div>
  )
}
