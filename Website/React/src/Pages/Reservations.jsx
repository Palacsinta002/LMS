import React from 'react'
import { useLocation } from 'react-router-dom'
import { useState, useEffect } from 'react';
import "../Styles/Dashboard.css"
import axios from 'axios';

export default function Reservations() {
  const location = useLocation()
  const [reservations, setReservations] = useState([]);
  const [loading, setLoading] = useState({});
  const [error, setError] = useState(null);
  const token = sessionStorage.getItem("token");

  const hidden = location.pathname === '/dashboard/reservations' ? '' : 'hidden'

  useEffect(() => {
    fetchReservations();
  }, [])

  const fetchReservations = () => {
    axios.get("/api/reserve", { headers: { "Authorization": `Bearer ${token}` } })
      .then(response => {
        setReservations(response.data)
      })
      .catch(err => {
        console.error(err)
        setError("Failed to fetch reservations");
      })
  }

  const handleCancel = (ISBN) => {
    setLoading(prev => ({ ...prev, [ISBN]: true }));
    setError(null);

    axios.delete(`/api/reserve/${ISBN}`, { 
      headers: { 
        "Authorization": `Bearer ${token}`,
        "Content-Type": "application/json"
      } 
    })
    .then(() => {
      setReservations(prev => prev.filter(item => item.ISBN !== ISBN));
    })
    .catch(err => {
      console.error(err);
      setError("Failed to cancel reservation");
    })
    .finally(() => {
      setLoading(prev => ({ ...prev, [ISBN]: false }));
    });
  }

  return (
    <div className={hidden}>
      {error && <div className="error-message">{error}</div>}
      <table className='dashboard-table'>
        <thead className='dashboard-thead'>
          <tr className='dashboard-tr'>
            <th className='dashboard-th'>ISBN</th>
            <th className='dashboard-th'>Title</th>
            <th className='dashboard-th'>Author</th>
            <th className='dashboard-th'>Reservation Start Date</th>
            <th className='dashboard-th'>Reservation End Date</th>
            <th className='dashboard-th'>Action</th>
          </tr>
        </thead>
        <tbody className='dashboard-tbody'>
          {reservations.map((item, index) => (
            <tr className='dashboard-tr' key={index}>
              <td className='dashboard-td' data-label="ISBN">{item.ISBN}</td>
              <td className='dashboard-td' data-label="Title">{item.Title}</td>
              <td className='dashboard-td' data-label="Authors">{item.Authors}</td>
              <td className='dashboard-td' data-label="Reservation Start Date">{item.ReservationStartDate}</td>
              <td className='dashboard-td' data-label="Reservation End Date">{item.ReservationEndDate}</td>
              <td className='dashboard-td' data-label="Action">
                <button 
                  type="button" 
                  onClick={() => handleCancel(item.ISBN)}
                  disabled={loading[item.ISBN]}
                  className="cancel-button"
                >
                  {loading[item.ISBN] ? "Cancelling..." : "Cancel"}
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  )
}