import React from 'react'
import Main from '../Components/Main'
import HeroBrowseBooks from '../Components/HeroBrowseBooks'
import "./Home.css"

export default function Home() {
  return (
    <div className="HeroSection">
      <section className="Hero">
        <Main />
      </section>
      <section className="BrowseBooks">
        <HeroBrowseBooks />
      </section>
    </div>
  )
}