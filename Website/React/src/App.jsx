import React, { useState } from 'react'
import { BrowserRouter, Routes, Route } from 'react-router-dom'
import Home from './Pages/Home'
import Header from './Components/Header'
import SignIn from './Pages/SignIn'
import SignUp from './Pages/SignUp'

function App() {
  const { currentPage, setCurrentPage } = useState("home");

  function handlePage(page){
    setCurrentPage(page);
    console.log(page);
  }
  console.log(currentPage)

  return (
    <BrowserRouter>
      <Header currentPage={currentPage} handlePage={handlePage} />
      <Routes>
        <Route path="/" exact element={<Home />} />
        <Route path="/SignIn" element={<SignIn />} />
        <Route path="/SignUp" element={<SignUp />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;