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
import Profile from './Pages/Profile';
import NotFound from './Pages/NotFound';
import AuthProvider from './Auth/AuthProvider';
import ForgotPassword from './Pages/ForgotPassword';
import ChangePassword from './Pages/ChangePassword';
import FinalizeRegistration from './Pages/FinalizeRegistration';
import DashboardLogin from './Pages/DashboardLogin';
import Books from './Pages/Books';

function App() {
  return (
    <AuthProvider>
      <BrowserRouter>
        <Header />
        <Routes>
          <Route path="/" exact element={<Home />} />
          <Route path="/login" element={<Login />} />
          <Route path="/forgot-password" element={<ForgotPassword />} />
          <Route path="/change-password/*" element={<ChangePassword />} />
          <Route path="/register" element={<Register />} />
          <Route path="/books" element={<Books />} />
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