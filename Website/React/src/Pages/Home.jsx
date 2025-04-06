import React, { useEffect, useState } from 'react'
import Main from '../Components/Main'
import "../Styles/Home.css"

export default function Home() {

  return (
    <div className="HeroSection">
      <section className="Hero">
        <Main />
      </section>
    </div>
  )
}