import React from 'react';
import Cards from '../Components/Cards';
import axios from 'axios';
import { useState, useEffect, useMemo } from 'react';

export default function Books({ searchQuery }) {
    const [books, setBooks] = useState([]);
    const [loading, setLoading] = useState(true);
    const [filters, setFilters] = useState({
        author: '',
        publisher: '',
        year: '',
        category: ''
    });

    const token = sessionStorage.getItem("token");

    useEffect(() => {
        const getData = async () => {
            try {
                const response = await axios.get("/api/available-books");
                console.log(response.data);
                setBooks(response.data);
            } catch (error) {
                console.error("Error fetching books:", error);
            } finally {
                setLoading(false);
            }
        };
        getData();
    }, []);

    const handleFilterChange = (e) => {
        const { name, value } = e.target;
        setFilters(prev => ({
            ...prev,
            [name]: value
        }));
    };

    const resetFilters = () => {
        setFilters({
            author: '',
            publisher: '',
            year: '',
            category: ''
        });
    };

    const filterOptions = useMemo(() => {
        const authors = new Set();
        const publishers = new Set();
        const years = new Set();
        const categories = new Set();

        books.forEach(book => {
            if (book.Authors) authors.add(book.Authors);
            if (book.Publisher) publishers.add(book.Publisher);
            if (book.publicationYear) years.add(book.publicationYear);
            if (book.Category) categories.add(book.Category);
        });

        return {
            authors: Array.from(authors).sort(),
            publishers: Array.from(publishers).sort(),
            years: Array.from(years).sort((a, b) => b - a),
            categories: Array.from(categories).sort()
        };
    }, [books]);

    const filteredBooks = useMemo(() => {
        let result = books;

        if (searchQuery) {
            const query = searchQuery.toLowerCase();
            result = result.filter(book => 
                book.Title?.toLowerCase().includes(query) ||
                book.Authors?.toLowerCase().includes(query)
            );
        }

        if (filters.author) {
            result = result.filter(book => 
                book.Authors?.toLowerCase().includes(filters.author.toLowerCase())
            );
        }
        if (filters.publisher) {
            result = result.filter(book => 
                book.Publisher?.toLowerCase().includes(filters.publisher.toLowerCase())
            );
        }
        if (filters.year) {
            result = result.filter(book => 
                String(book.publicationYear) === filters.year
            );
        }
        if (filters.category) {
            result = result.filter(book => 
                book.Category?.toLowerCase() === filters.category.toLowerCase()
            );
        }

        return result;
    }, [books, searchQuery, filters]);

    async function handleReserve(isbn) {
        if (!token) {
            alert("Error: You need to be authenticated to reserve books");
            return;
        }

        try {
            const response = await axios.post(`/api/reserve`,
                { ISBN: isbn },
                {
                    headers: {
                        "Content-type": "application/json",
                        "Authorization": `Bearer ${token}`
                    }
                });

            if (response.data.Success) {
                setBooks(prevBooks => prevBooks.filter(book => book.ISBN !== isbn));
            }
        } catch (error) {
            if (error.response) {
                console.log(error.response.data);
                alert(error.response.data.message || "You can only reserve 3 books at a time!");
            }
        }
    }

    return (
        <div className="books-container">
            <div className="filters-section">
                <h3>Filter Books</h3>
                <div className="filter-grid">
                    <div className="filter-group">
                        <label htmlFor="author-filter">Author</label>
                        <select
                            id="author-filter"
                            name="author"
                            value={filters.author}
                            onChange={handleFilterChange}
                        >
                            <option value="">All Authors</option>
                            {filterOptions.authors.map(author => (
                                <option key={author} value={author}>{author}</option>
                            ))}
                        </select>
                    </div>

                    <div className="filter-group">
                        <label htmlFor="publisher-filter">Publisher</label>
                        <select
                            id="publisher-filter"
                            name="publisher"
                            value={filters.publisher}
                            onChange={handleFilterChange}
                        >
                            <option value="">All Publishers</option>
                            {filterOptions.publishers.map(publisher => (
                                <option key={publisher} value={publisher}>{publisher}</option>
                            ))}
                        </select>
                    </div>

                    <div className="filter-group">
                        <label htmlFor="year-filter">Publication Year</label>
                        <select
                            id="year-filter"
                            name="year"
                            value={filters.year}
                            onChange={handleFilterChange}
                        >
                            <option value="">All Years</option>
                            {filterOptions.years.map(year => (
                                <option key={year} value={year}>{year}</option>
                            ))}
                        </select>
                    </div>

                    <div className="filter-group">
                        <label htmlFor="category-filter">Category</label>
                        <select
                            id="category-filter"
                            name="category"
                            value={filters.category}
                            onChange={handleFilterChange}
                        >
                            <option value="">All Categories</option>
                            {filterOptions.categories.map(category => (
                                <option key={category} value={category}>{category}</option>
                            ))}
                        </select>
                    </div>

                    <button 
                        className="reset-filters" 
                        onClick={resetFilters}
                    >
                        Reset Filters
                    </button>
                </div>
            </div>

            <div className="results-count">
                {filteredBooks.length} {filteredBooks.length === 1 ? 'book' : 'books'} found
            </div>

            {loading ? (
                <p>Loading books...</p>
            ) : (
                <div id="browsebooks" className="cards-list">
                    {filteredBooks.length > 0 ? (
                        filteredBooks.map((item) => (
                            <Cards
                                key={item.ISBN}
                                isbn={item.ISBN}
                                category={item.Category}
                                title={item.Title}
                                author={item.Authors}
                                publisher={item.Publisher}
                                year={item.PublicationYear}
                                onClick={() => handleReserve(item.ISBN)}
                            />
                            ))
                    ) : (
                        <p className="no-results">No books match your filters.</p>
                    )}
                </div>
            )}
        </div>
    );
}