import React from 'react'
import { useLocation } from 'react-router-dom'

export default function Profile() {
  const location = useLocation()

  const hidden = location.pathname === '/dashboard/profile' ? '' : 'hidden'
  return (
    <div className={hidden}>Profile</div>
  )
}
