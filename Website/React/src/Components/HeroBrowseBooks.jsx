import React from 'react'
import Cards from '../Components/Cards';
import axios from 'axios';
import { useState, useEffect } from 'react';
import { Link } from "react-scroll";

export default function HeroBrowseBooks() {
    const [books, setBooks] = useState([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        const getData = async () => {
            try {
                const response = await axios.get("/api/books");
                setBooks(response.data);
            } catch (error) {
                console.error("Error fetching books:", error);
            } finally {
                setLoading(false);
            }
        };
        getData();
    }, []);
    return (
        <div>
            <div className="BrowseBooks">
                <Link smooth={true} duration={500} to="browsebooks" className="BrowseBooks-link">
                    <p>Browse books</p>
                    <i className="fa fa-caret-down"></i>
                </Link>
            </div>
            {loading ? (
                <p>Loading books...</p>
            ) : (
                <div id="browsebooks" className="cards-list">
                    {books.map((item) => (
                        <Cards key={item.ISBN} index={item.ISBN} img={item.ISBN} title={item.Title} author={item.Authors} />
                    ))}
                </div>
            )}
        </div>
    );
}
