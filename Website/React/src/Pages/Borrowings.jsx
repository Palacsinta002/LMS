import React, { useState, useEffect } from 'react';
import { useLocation } from 'react-router-dom';
import axios from 'axios';

export default function Borrowings() {
  const [borrowings, setBorrowings] = useState([]);
  const location = useLocation();

  const hidden = location.pathname === '/dashboard/borrowings' ? '' : 'hidden';

  useEffect(() => {
    axios.get("api/borrowings")
    .then(data => setBorrowings(data));
  }, [])

  return (
    <div className={hidden}>
      <table>
        
      {borrowings.map((items) => (
        
      ))}
      </table>
    </div>
  )
}
