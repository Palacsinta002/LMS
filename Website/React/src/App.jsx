import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Home from './Pages/Home';
import Header from './Components/Header';
import Login from './Pages/Login';
import Register from './Pages/Register';
import Dashboard from './Pages/Dashboard';
import PrivateRoute from './Hooks/PrivateRoute';
import Verify from './Pages/Verify';
import Borrowings from './Pages/Borrowings';
import Reservations from './Pages/Reservations';
import Charts from './Pages/Charts';
import Profile from './Pages/Profile';
import NotFound from './Pages/NotFound';

function App() {
  return (
    <BrowserRouter>
      <Header />
      <Routes>
        <Route path="/" exact element={<Home />} />
        <Route path="/login" element={<Login />} />
        <Route path="/register" element={<Register />} />
        <Route path="/verify" element={<Verify />} />
        <Route path="/dashboard" element={<PrivateRoute><Dashboard /></PrivateRoute>}>
          <Route path="borrowings" element={<Borrowings />} />
          <Route path="reservations" element={<Reservations />} />
          <Route path="charts" element={<Charts />} />
          <Route path="profile" element={<Profile />} />
        </Route>
        <Route path="*" element={<NotFound />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;