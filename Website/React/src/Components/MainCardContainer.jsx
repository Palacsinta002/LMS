import React from 'react'
import "../index.css"
import { useEffect, useState } from 'react';
import axios from 'axios';

export default function MainCardContainer() {
  const [books, setBooks] = useState([]);
  const [members, setMembers] = useState([]);
  const [borrows, setBorrows] = useState([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState("");

  const cardData = [
    { icon: "fa-bookmark", title: "Books", count: books },
    { icon: "fa-user", title: "Members", count: members },
    { icon: "fa-search", title: "Borrows", count: borrows },
  ];

  useEffect(() => {
    const getData = async () => {
      try {
        const response = await axios.get(`/api/all-books`);
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
  useEffect(() => {
    const getData = async () => {
      try {
        const response = await axios.get(`/api/all-user`);
        console.log(response.data);
        setMembers(response.data);
      } catch (error) {
        console.error("Error fetching books:", error);
        setError("Failed to fetch data");
      } finally {
        setLoading(false);
      }
    };
    getData();
  }, []);
  useEffect(() => {
    const getData = async () => {
      try {
        const response = await axios.get(`/api/all-borrowings`);
        console.log(response.data);
        setBorrows(response.data);
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
    <div className="card-container">
      {books.map((item, index) => (
        <div key={index} className="cards">
          <i className="fa-bookmark"></i>
          <h2>Books</h2>
          <p>{item.books}</p>
        </div>
      ))}
      {members.map((item, index) => (
        <div key={index} className="cards">
          <i className="fa-user"></i>
          <h2>Members</h2>
          <p>{item.users}</p>
        </div>
      ))}
      {borrows.map((item, index) => (
        <div key={index} className="cards">
          <i className="fa-search"></i>
          <h2>Borrowings</h2>
          <p>{item.borrowings}</p>
        </div>
      ))}
    </div>
  )
}