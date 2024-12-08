import React, { useState } from 'react'
import { BrowserRouter, Routes, Route } from 'react-router-dom'
import { useState, useEffect } from 'react'
import Home from './Pages/Home'
import Header from './Components/Header'
import SignIn from './Pages/SignIn'
import SignUp from './Pages/SignUp'

function App() {
<<<<<<< HEAD
  const { currentPage, setCurrentPage } = useState("home");

  function handlePage(page){
    setCurrentPage(page);
    console.log(page);
  }
  console.log(currentPage)
=======
  const {hidden, setHidden } = useState("");
>>>>>>> 561256eb2facf9ad5744e47990583594e03b58e9

  function handleHidden(){
    setHidden("hidden");
  }
  return (
<<<<<<< HEAD
    <BrowserRouter>
      <Header currentPage={currentPage} handlePage={handlePage} />
      <Routes>
        <Route path="/" exact element={<Home />} />
        <Route path="/SignIn" element={<SignIn />} />
        <Route path="/SignUp" element={<SignUp />} />
      </Routes>
    </BrowserRouter>
  );
=======
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
>>>>>>> 561256eb2facf9ad5744e47990583594e03b58e9
}

export default App;