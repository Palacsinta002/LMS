import React from 'react'
import Header from "./Components/Header"
import Main from './Components/Main'

function App() {

  return (
    <>
      <div className="HeroSection">
        <Header />
        <section className="Hero">
          <Main />
        </section>
      </div>
    </>
  )
}

export default App