import React, { useState, useEffect } from 'react';
import { useLocation } from 'react-router-dom';
import axios from 'axios';
import { jwtDecode } from 'jwt-decode';

export default function Borrowings() {
  const [borrowings, setBorrowings] = useState([]);
  const location = useLocation();
  const token = sessionStorage.getItem("token");
  const decoded = jwtDecode(token);

  const hidden = location.pathname === '/dashboard/borrowings' ? '' : 'hidden';
  console.log(decoded)
  useEffect(() => {
    axios.get("/api/my-borrowed-books", { headers: { "Authorization": `Bearer ${token}` } })
      .then(response => {
        console.log(response.data)
        setBorrowings(response.data)
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
          {borrowings.map((items, index) => (
            <tr className='dashboard-tr' key={index}>
              <td className='dashboard-td'>{items.ISBN}</td>
              <td className='dashboard-td'>{items.Title}</td>
              <td className='dashboard-td'>{items.Authors}</td>
              <td className='dashboard-td'>{items.BorrowDate}</td>
              <td className='dashboard-td'>{items.DueDate}</td>
              <td className='dashboard-td'></td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  )
}
