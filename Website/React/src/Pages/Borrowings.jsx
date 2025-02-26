import React from 'react'
import { useLocation } from 'react-router-dom'

export default function Borrowings() {
  const location = useLocation()

  const hidden = location.pathname === '/dashboard/borrowings' ? '' : 'hidden'

  return (
    <div className={hidden}>Borrowings</div>
  )
}
