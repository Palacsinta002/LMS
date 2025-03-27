import React from 'react'
import Cards from '../Components/Cards';
import axios from 'axios';
import { useState, useEffect } from 'react';
import { Link } from "react-scroll";

export default function HeroBrowseBooks() {
    const [books, setBooks] = useState([]);
    const [loading, setLoading] = useState(true);

    const token = sessionStorage.getItem("token")

    useEffect(() => {
        const getData = async () => {
            try {
                const response = await axios.get("/api/available-books");
                setBooks(response.data);
            } catch (error) {
                console.error("Error fetching books:", error);
            } finally {
                setLoading(false);
            }
        };
        getData();
    }, []);


    async function handleReserve(isbn) {
        if(!token){
            "Error: The user have to be authenticated";
            return;
        }


        try {
            const response = await axios.post(`/api/reserve`,
                {
                    ISBN: isbn
                },
                {
                    headers: {
                        "Content-type": "application/json",
                        "Authorization": `Bearer ${token}`
                    }
                })

            if (response.data.Success) {
                console.log("jó")
            }
        }
        catch (error) {
            if (error.response) {
                console.log(error.response.data)
            }
        }
    }

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
                    {books.map((item, index) => (
                        <Cards
                            key={index}
                            isbn={item.ISBN}
                            category={item.Category}
                            title={item.Title}
                            author={item.Authors}
                            onClick={() => handleReserve(item.ISBN)}
                        />
                    ))}
                </div>
            )}
        </div>
    );
}