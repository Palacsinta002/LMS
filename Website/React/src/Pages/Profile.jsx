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
  const [currentPassword, setCurrentPassword] = useState("");
  const [newPassword, setNewPassword] = useState("");
  const [newPasswordAgain, setNewPasswordAgain] = useState("");
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState("");

  useEffect(() => {
    axios.post("/api/user", JSON.stringify({ ID: ID }),
      {
        headers: {
          "Content-type": "application/json",
          "Authorization": `Bearer ${token}`
        }
      })
      .then(response => {
        setData(response.data)
      })
  }, [ID, token])

  async function handleSubmit() {
    setLoading(true);
    setError("");

    if (newPassword != newPasswordAgain) {
      setLoading(false);
      setError("The new password doesn't match!");
      return;
    }
    try {
      const response = await axios.post("/api/update-user",
        { firstname: firstname, lastname: lastname, username: username, address: address, passwordOld: currentPassword, password: newPassword },
        {
          headers: {
            "Content-type": "application/json",
            "Authorization": `Bearer ${token}`
          }
        })

      if (response.data.Success) {
        console.log(response.data)
      }
    }
    catch (error) {
      console.error("Registration error:", error);
      setError("Registration error!");
    } finally {
      setLoading(false);
    }

  }

  return (
    <div className={hidden}>
      {data.map((item, index) => (
        <form onSubmit={handleSubmit} key={index} className="profile-box">
          <label>First name:</label>
          <input className='profile-firstname' defaultValue={item.firstname} onChange={(e) => setFirstname(e.target.value)} type="text" />
          <label>Last name:</label>
          <input className='profile-lastname' defaultValue={item.lastname} onChange={(e) => setLastname(e.target.value)} type="text" />
          <label>Username:</label>
          <input className='profile-username' defaultValue={item.username} onChange={(e) => setUsername(e.target.value)} type="text" />
          <label>Address:</label>
          <input className='profile-username' defaultValue={item.address} onChange={(e) => setAddress(e.target.value)} type="text" />
          <label>Current Password:</label>
          <input className='proflie-password' type="password" onChange={(e) => setCurrentPassword(e.target.value)} />
          <label>New Password:</label>
          <input className='proflie-password' type="password" onChange={(e) => setNewPassword(e.target.value)} />
          <label>New Password Again:</label>
          <input className='proflie-password' type="password" onChange={(e) => setNewPasswordAgain(e.target.value)} />
          <input type="submit" className="profile-submit" value={loading ? "Saving changes..." : "Save"} disabled={loading} />
          {loading && <div className="spinner"></div>}
        </form>
      ))}
    </div>
  )
}
