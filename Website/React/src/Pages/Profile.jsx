import React, { useEffect, useState } from 'react'
import { useLocation } from 'react-router-dom'
import axios from 'axios';

export default function Profile() {
  const location = useLocation();
  const hidden = location.pathname === '/dashboard/profile' ? '' : 'hidden';

  const [data, setData] = useState([]);

  useEffect(() => {
    axios.post("api/user", {token: sessionStorage.getItem("token")}, {headers: {"Content-type": "application/json"} })
      .then(response => {
        console.log(response.data)
      })
  }, [])

  return (
    <div className={hidden}>
      {data.map((item) => (
        <div className="profile-box">
          <label>First name:</label>
          <input className='profile-firstname' value={item.firstname} type="text" />
          <label>Last name:</label>
          <input className='profile-lastname' value={item.lastname} type="text" />
          <label>Username:</label>
          <input className='profile-username' value={item.username} type="text" />
          <label>Password:</label>
          <input className='proflie-password' type="password" />
          <input className='profile-submit' type="submit" value="Save" />
        </div>
      ))}
    </div>
  )
}
