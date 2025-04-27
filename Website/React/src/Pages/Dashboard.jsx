import React from 'react'
import DashboardHeader from '../Components/DashboardHeader';
import Borrowings from './Borrowings';
import Reservations from './Reservations';
import Profile from './Profile';

export default function Dashboard() {
  return (
    <div>
      <DashboardHeader />
      <Borrowings />
      <Reservations />
      <Profile />
    </div>
  )
}