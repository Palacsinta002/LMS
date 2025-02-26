import React from 'react'
import { useLocation } from 'react-router-dom'

export default function Charts() {
  const location = useLocation()

  const hidden = location.pathname === '/dashboard/charts' ? '' : 'hidden'
  return (
    <div className={hidden}>Charts</div>
  )
}
