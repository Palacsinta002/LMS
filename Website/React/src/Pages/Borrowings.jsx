import React, { useState, useEffect } from 'react';
import { useLocation } from 'react-router-dom';
import axios from 'axios';

export default function Borrowings() {
  const [borrowings, setBorrowings] = useState([]);
  const location = useLocation();

  const hidden = location.pathname === '/dashboard/borrowings' ? '' : 'hidden';

  useEffect(() => {
    axios.post("/api/borrowings")
      .then(response => {
        setBorrowings(response.data)
      })
      .catch(err => console.error(err))
  }, [])

  return (
    <div className={hidden}>
      <table>
        <thead>
          <tr>
            <th>ISBN</th>
            <th>Title</th>
            <th>Borrowings Date</th>
            <th>Due Date</th>
          </tr>
        </thead>
        <tbody>
          {borrowings.map((items, index) => (
            <tr key={index}>
              <td>{items.ISBN}</td>
              <td>{items.Title}</td>
              <td>{items.borrowDate}</td>
              <td>{items.dueDate}</td>
              <td></td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  )
}
