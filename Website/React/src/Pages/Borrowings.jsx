import React, { useState, useEffect } from 'react';
import { useLocation } from 'react-router-dom';
import axios from 'axios';

export default function Borrowings() {
  const [borrowings, setBorrowings] = useState([]);
  const location = useLocation();
  const token = sessionStorage.getItem("token");

  const hidden = location.pathname === '/dashboard/borrowings' ? '' : 'hidden';
  useEffect(() => {
    axios.get("/api/borrowings", { headers: { "Authorization": `Bearer ${token}` } })
      .then(response => {
        setBorrowings(response.data)
        console.log(response.data)
      })
      .catch(err => console.error(err))
  }, [])

  return (
    <div className={hidden}>
      <table className='dashboard-table'>
        <thead className='dashboard-thead'>
          <tr className='dashboard-tr'>
            <th className='dashboard-th'>ISBN</th>
            <th className='dashboard-th'>Title</th>
            <th className='dashboard-th'>Author</th>
            <th className='dashboard-th'>Borrowings Date</th>
            <th className='dashboard-th'>Due Date</th>
          </tr>
        </thead>
        <tbody className='dashboard-tbody'>
          {borrowings.map((items) => (
            <tr className='dashboard-tr' key={items.ISBN}>
              <td className='dashboard-td' data-label="ISBN">{items.ISBN}</td>
              <td className='dashboard-td' data-label="Title">{items.Title}</td>
              <td className='dashboard-td' data-label="Author">{items.Authors}</td>
              <td className='dashboard-td' data-label="Borrowings Date">{items.BorrowDate}</td>
              <td className='dashboard-td' data-label="Due Date">{items.DueDate}</td>
            </tr>
          ))}
        </tbody>

      </table>
    </div>
  )
}
