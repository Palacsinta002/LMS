import React from 'react'
import Cards from '../Components/Cards';
import axios from 'axios';
import { useState, useEffect } from 'react';

export default function HeroBrowseBooks() {
    const [books, setBooks] = useState([]);

    useEffect(() => {
        const getData = async () => {
            await axios.get("/api/books")
                .then(response => {
                    console.log(response.data)
                    setBooks(response.data)
                })
        }
        getData()
    }, [])
    return (
        <div className="BrowseBooks">
            <a href="">
                <p>Browse books</p>
                <i className="fa fa-caret-down"></i>
            </a>
            <div className="cards-list">
                {books.map((item) => (
                    <Cards index={item.id} img={item.isbn} title={item.title} author={item.author} />
                ))}
            </div>
        </div>
    )
}
