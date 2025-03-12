import React, { createContext, useState, useEffect } from 'react';
import { jwtDecode } from "jwt-decode";

const AuthContext = createContext();

export default function AuthProvider({ children }) {
    const [user, setUser] = useState(null);

    useEffect(() => {
        const token = sessionStorage.getItem("token");
        if (token) {
            try {
                const decoded = jwtDecode(token);
                if (decoded.exp * 1000 > Date.now()) {
                    setUser(decoded);
                } else {
                    alert("Session expired. Please log in again.")
                    sessionStorage.removeItem("token");
                    window.locaion.relead();
                    setUser(null);
                }
            } catch (error) {
                console.error("Invalid token:", error);
                sessionStorage.removeItem("token");
                setUser(null);
            }
        }
    }, []);

    const login = (token) => {
        sessionStorage.setItem("token", token);
        const decoded = jwt_decode(token);
        setUser(decoded);
    }

    const logout = () => {
        sessionStorage.removeItem("token");
        setUser(null);
    }

    return (
        <AuthContext.Provider value={{ user, setUser, login, logout }}>
            {children}
        </AuthContext.Provider>
    );
}