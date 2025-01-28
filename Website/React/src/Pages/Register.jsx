import React, { useEffect, useState } from 'react'
import { Link, useNavigate } from 'react-router-dom'
import "./Register.css"
import FormCard from '../Components/FormCard'
import axios from 'axios'

export default function Register() {
  const [email, setEmail] = useState("");
  const [username, setUsername] = useState("");
  const [firstname, setFirstname] = useState("");
  const [lastname, setLastname] = useState("");
  const [password, setPassword] = useState("");
  const [passwordAgain, setPasswordAgain] = useState("");
  const [error, setError] = useState("");
  const navigate = useNavigate();

  async function HandleSubmit(e) {
    e.preventDefault();
    await axios.post("http://localhost/LMS/Website/PHP/RealProject/users/userapi.php/register", {
      username: username,
      password: password,
      email: email,
      firstname: firstname,
      lastname: lastname,
      passwordAgain: passwordAgain
    })
    .then(response => console.log(JSON.stringify(response)))
    .catch(error => console.log(error))
  }
  async function HandleSubmit(event){
    event.preventDefault();
    try{
      const response = await axios.post("http://localhost/LMS/Website/PHP/RealProject/users/userapi.php/login", {username, password, email, firstname, lastname, passwordAgain})
      navigate("/login");
    }
    catch(error){
      console.log(error);
      setError("Not authorized!");
    }
  }
  return (
    <div className="register">
      <div className="register-header">
        <h1 className="register-top">Welcome to</h1>
        <h2 className="register-bottom">Library Management System</h2>
      </div>
      <div className="register-container">
        <i className="fa fa-user"></i>
        <h1>Register Account</h1>
        <form onSubmit={HandleSubmit}>
          <div className="register-card-holder">
            <FormCard className="register-card" label="Email" type="email" onChange={(e) => setEmail(e.target.value)}/>
            <FormCard className="register-card" label="Username" type="text" onChange={(e) => setUsername(e.target.value)}/>
            <FormCard className="register-card" label="First name" type="text" onChange={(e) => setFirstname(e.target.value)}/>
            <FormCard className="register-card" label="Last name" type="text" onChange={(e) => setLastname(e.target.value)}/>
            <FormCard className="register-card" label="Password" type="password" onChange={(e) => setPassword(e.target.value)}/>
            <FormCard className="register-card" label="Password again" type="password" onChange={(e) => setPasswordAgain(e.target.value)}/>
          </div>
          <center>
            <div className="actions">
              <input type="submit" value="Sign in"/>
              <span><Link to="/login" className="link2">I already have an account!</Link></span>
            </div>
          </center>
        </form>
      </div>
    </div>
  )
}
