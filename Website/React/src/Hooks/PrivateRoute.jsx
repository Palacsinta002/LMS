import React from "react";
import { Navigate } from "react-router-dom";

export default function PrivateRoute({ children }) {
  const isAuthorized = !!localStorage.getItem("token");

  return isAuthorized ? children : <Navigate to="/login" />;
}