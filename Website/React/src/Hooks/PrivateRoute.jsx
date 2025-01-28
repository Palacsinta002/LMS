import React from 'react';
import { Navigate } from 'react-router-dom';

export default function PrivateRoute({props}) {
    const isAuthorized = !!localStorage.getItem("token");
    return isAuthorized ? props : <Navigate to="/login" />;
}
