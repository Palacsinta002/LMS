import React from 'react'
import Header from '../Components/Header'
import Main from '../Components/Main'
import HeroBrowseBooks from '../Components/HeroBrowseBooks'


export default function Home() {
  return (
    <div className="HeroSection">
          <section className="Hero">
            <Main />
          </section>
          <HeroBrowseBooks />
    </div>
  )
}
