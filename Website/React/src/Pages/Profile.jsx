import React, { useEffect, useState } from 'react'
import { useLocation } from 'react-router-dom'
import axios from 'axios';
import { jwtDecode } from 'jwt-decode';

export default function Profile() {
  const location = useLocation();
  const hidden = location.pathname === '/dashboard/profile' ? '' : 'hidden';

  const token = sessionStorage.getItem("token");
  const decoded = jwtDecode(token);
  const ID = decoded.userID;

  const [data, setData] = useState([]);
  const [firstname, setFirstname] = useState("");
  const [lastname, setLastname] = useState("");
  const [username, setUsername] = useState("");
  const [address, setAddress] = useState("");

  useEffect(() => {
    axios.post("/api/user", {ID: ID}, {headers: {"Content-type": "application/json"} })
      .then(response => {
        setData(response.data)
      })
  }, [])

  return (
    <div className={hidden}>
      {data.map((item, index) => (
        <div key={index} className="profile-box">
          <label>First name:</label>
          <input className='profile-firstname' defaultValue={item.firstname} onChange={(e) => setFirstname(e.target.value)} type="text" />
          <label>Last name:</label>
          <input className='profile-lastname' defaultValue={item.lastname} onChange={(e) => setLastname(e.target.value)} type="text" />
          <label>Username:</label>
          <input className='profile-username' defaultValue={item.username} onChange={(e) => setUsername(e.target.value)} type="text" />
          <label>Address:</label>
          <input className='profile-username' defaultValue={item.address} onChange={(e) => setAddress(e.target.value)} type="text" />
          <label>Password:</label>
          <input className='proflie-password' type="password" />
          <input className='profile-submit' type="submit" value="Save" />
        </div>
      ))}
    </div>
  )
}
