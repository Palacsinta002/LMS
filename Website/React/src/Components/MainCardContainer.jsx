import React from 'react';
import "../index.css";
import { useEffect, useState } from 'react';
import axios from 'axios';

export default function MainCardContainer() {
  const [books, setBooks] = useState([]);
  const [members, setMembers] = useState([]);
  const [borrows, setBorrows] = useState([]);
  const [loading, setLoading] = useState({ books: true, members: true, borrows: true });
  const [error, setError] = useState({ books: "", members: "", borrows: "" });

  useEffect(() => {
    const fetchBooks = async () => {
      try {
        const response = await axios.get(`/api/all-books`);
        setBooks(response.data);
      } catch (error) {
        console.error("Error fetching books:", error);
        setError((prev) => ({ ...prev, books: "Failed to fetch books data" }));
      } finally {
        setLoading((prev) => ({ ...prev, books: false }));
      }
    };
    fetchBooks();
  }, []);

  useEffect(() => {
    const fetchMembers = async () => {
      try {
        const response = await axios.get(`/api/all-users`);
        setMembers(response.data);
      } catch (error) {
        console.error("Error fetching members:", error);
        setError((prev) => ({ ...prev, members: "Failed to fetch members data" }));
      } finally {
        setLoading((prev) => ({ ...prev, members: false }));
      }
    };
    fetchMembers();
  }, []);

  useEffect(() => {
    const fetchBorrows = async () => {
      try {
        const response = await axios.get(`/api/all-borrowings`);
        setBorrows(response.data);
      } catch (error) {
        console.error("Error fetching borrowings:", error);
        setError((prev) => ({ ...prev, borrows: "Failed to fetch borrowings data" }));
      } finally {
        setLoading((prev) => ({ ...prev, borrows: false }));
      }
    };
    fetchBorrows();
  }, []);

  return (
    <div className="card-container">
      {loading.books ? (
        <p>Loading books...</p>
      ) : error.books ? (
        <p className="error">{error.books}</p>
      ) : (
        books.map((item, index) => (
          <div key={index} className="cards">
            <i className="fas fa-bookmark"></i>
            <h2>Books</h2>
            <p>{item.books}</p>
          </div>
        ))
      )}

      {loading.members ? (
        <p>Loading members...</p>
      ) : error.members ? (
        <p className="error">{error.members}</p>
      ) : (
        members.map((item, index) => (
          <div key={index} className="cards">
            <i className="fas fa-user"></i>
            <h2>Members</h2>
            <p>{item.users}</p>
          </div>
        ))
      )}

      {loading.borrows ? (
        <p>Loading borrowings...</p>
      ) : error.borrows ? (
        <p className="error">{error.borrows}</p>
      ) : (
        borrows.map((item, index) => (
          <div key={index} className="cards">
            <i className="fas fa-search"></i>
            <h2>Borrowings</h2>
            <p>{item.borrowings}</p>
          </div>
        ))
      )}
    </div>
  );
}