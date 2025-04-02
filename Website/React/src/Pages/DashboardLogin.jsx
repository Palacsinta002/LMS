import React from 'react'
import { useLocation } from 'react-router-dom'
import MainCardContainer from '../Components/MainCardContainer'

export default function Dashboard() {
  const location = useLocation()

  const hidden = location.pathname === '/dashboard/dashboard' ? '' : 'hidden'
  return (
    <div className={hidden}><MainCardContainer /></div>
  )
}
