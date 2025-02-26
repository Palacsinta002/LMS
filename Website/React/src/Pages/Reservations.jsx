import React from 'react'
import { useLocation } from 'react-router-dom'

export default function Reservations() {
  const location = useLocation()

  const hidden = location.pathname === '/dashboard/reservations' ? '' : 'hidden'
  return (
    <div className={hidden}>Reservations</div>
  )
}
