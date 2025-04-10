import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import { useState } from 'react';
import Home from './Pages/Home';
import Header from './Components/Header';
import Login from './Pages/Login';
import Register from './Pages/Register';
import Dashboard from './Pages/Dashboard';
import PrivateRoute from './Hooks/PrivateRoute';
import Verify from './Pages/Verify';
import Borrowings from './Pages/Borrowings';
import Reservations from './Pages/Reservations';
import Profile from './Pages/Profile';
import NotFound from './Pages/NotFound';
import AuthProvider from './Auth/AuthProvider';
import ForgotPassword from './Pages/ForgotPassword';
import ChangePassword from './Pages/ChangePassword';
import FinalizeRegistration from './Pages/FinalizeRegistration';
import DashboardLogin from './Pages/DashboardLogin';
import Books from './Pages/Books';

function App() {
  const [searchQuery, setSearchQuery] = useState("");

  function handleSearch(e) {
    setSearchQuery(e.target.value);
  }

  return (
    <AuthProvider>
      <BrowserRouter>
        <Header searchQuery={searchQuery} onSearch={handleSearch} />
        <Routes>
          <Route path="/" exact element={<Home />} />
          <Route path="/login" element={<Login />} />
          <Route path="/forgot-password" element={<ForgotPassword />} />
          <Route path="/change-password/*" element={<ChangePassword />} />
          <Route path="/register" element={<Register />} />
          <Route path="/books" element={<Books searchQuery={searchQuery} />} />
          <Route path="/finalize-registration" element={<FinalizeRegistration />} />
          <Route path="/verify" element={<Verify />} />
          <Route path="/dashboard" element={<PrivateRoute><Dashboard /></PrivateRoute>}>
            <Route path="borrowings" element={<Borrowings />} />
            <Route path="reservations" element={<Reservations />} />
            <Route path="dashboard" element={<DashboardLogin />} />
            <Route path="profile" element={<Profile />} />
          </Route>
          <Route path="*" element={<NotFound />} />
        </Routes>
      </BrowserRouter>
    </AuthProvider>
  );
}

export default App;