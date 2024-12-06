import React from 'react'
import Header from "./Components/Header"
import Main from './Components/Main'
import HeroBrowseBooks from './Components/HeroBrowseBooks'

function App() {

  return (
    <>
      <div className="HeroSection">
        <Header />
        <section className="Hero">
          <Main />
        </section>
        <HeroBrowseBooks />
      </div>
    </>
  )
}

export default App