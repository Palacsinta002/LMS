import React from 'react'
import { BrowserRouter, Routes, Route } from 'react-router-dom'
import { useState, useEffect } from 'react'
import Home from './Pages/Home'
import Header from './Components/Header'
import SignIn from './Pages/SignIn'
import SignUp from './Pages/SignUp'

function App() {
  const {hidden, setHidden } = useState("");

  function handleHidden(){
    setHidden("hidden");
  }
  return (
    <>
      <BrowserRouter>
        <Header onClick={handleHidden()} className={hidden} />
        <Routes>
          <Route index element={<Home />} />
          <Route path="/home" element={<Home />} />
          <Route path="/SignIn" element={<SignIn />} />
          <Route path="/SignUp" element={<SignUp />} />
        </Routes>
      </BrowserRouter>
    </>
  )
}

export default App