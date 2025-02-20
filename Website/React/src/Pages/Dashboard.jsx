import React from 'react'
import DashboardHeader from '../Components/DashboardHeader';
import { BrowserRouter, Routes, Route } from 'react-router-dom';

export default function Dashboard() {

  return (
    <div>
      <BrowserRouter>
        <Routes>
          <Route path='/dashboard' element={<Dashboard />}/>
          <Route path='/borrowings' element={<Borrowings />}/>
          <Route path='/reservations'element={<Reservations />}/>
          <Route path='/profile' element={<Profile />}/>
        </Routes>
      </BrowserRouter>
      <DashboardHeader />
    </div>
  )
}
