import React from 'react'
import { useLocation } from 'react-router-dom'

export default function Profile() {
  const location = useLocation()

  const hidden = location.pathname === '/dashboard/profile' ? '' : 'hidden'
  return (
    <div className={hidden}>
      <div className="profile-box">
        <label>Username:</label>
        <input className='profile-username' type="text" />
        <label>Password:</label>
        <input className='proflie-password' type="password" />
        <input className='profile-submit' type="submit" value="Update" />
      </div>
    </div>
  )
}
