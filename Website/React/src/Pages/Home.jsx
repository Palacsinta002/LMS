import React, { useEffect, useState } from 'react'
import Main from '../Components/Main'
import HeroBrowseBooks from '../Components/HeroBrowseBooks'
import "./Home.css"
import Cards from '../Components/Cards';
import axios from 'axios';

export default function Home() {
  const [books, setBooks] = useState([]);

  useEffect(() => {
    axios.get("/api/books")
      .then(response => {
        console.log(response.data)
      })
  })

  return (
    <div className="HeroSection">
      <section className="Hero">
        <Main />
      </section>
      <section className="BrowseBooks">
        <HeroBrowseBooks />
        {books.map((item) => (
          <Cards index={item.id} img={item.isbn} title={item.title} publisher={item.publisher} author={item.author} publicationYear={item.publicationYear} />
        ))}
      </section>
    </div>
  )
}