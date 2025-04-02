import React from 'react';
import TopCards from './TopCards';
import axios from 'axios';
import "./SliderColousel.css";
import { useState, useEffect } from 'react';

export default function SliderColousel() {
    const settings = {
        dots: true,
        infinite: true,
        speed: 500,
        slidesToShow: 1,
        slidesToScroll: 1,
    };
    const [books, setBooks] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        const getData = async () => {
            try {
                const response = await axios.get(`/api/top-borrowings/5`);
                console.log(response.data);
                setBooks(response.data);
            } catch (error) {
                console.error("Error fetching books:", error);
                setError("Failed to fetch data");
            } finally {
                setLoading(false);
            }
        };
        getData();
    }, []);

    return (
        <div children="slider-container">
            <h2 className="slider-title">Top Borrowed Books</h2>
            {error && <div className="error-message">{error}</div>}
                {loading ? (
                    <p>Loading books...</p>
                ) : (
                    <div id="browsebooks" className="slider-cards-list">
                        {books.map((item, index) => (
                            <TopCards
                                key={index}
                                isbn={item.ISBN}
                                category={item.Category}
                                title={item.Title}
                                author={item.Authors}
                            />
                        ))}
                    </div>
                )}
        </div>
    );
}