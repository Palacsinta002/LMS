import React from 'react'
import "../index.css"
import { useEffect, useState } from 'react';

export default function MainCardContainer() {
  const cardData = [
    { icon: "fa-bookmark", title: "Books", count: 123 },
    { icon: "fa-user", title: "Members", count: 123 },
    { icon: "fa-search", title: "Borrows", count: 123 },
  ];

  const [books, setBooks] = useState("");
  const [members, setMembers] = useState("");
  const [borrows, setBorrows] = useState("");

  useEffect(() => {
    const getData = async () => {
      try {
        const response = await axios.get(`/api/top-borrowings/5`);
        console.log(response.data);
        setData(response.data);
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
      {cardData.map((card, index) => (
        <div className="cards" key={index}>
          <i className={`fa ${card.icon}`}></i>
          <h2>{card.title}</h2>
          <p>{card.count}</p>
        </div>
      ))}
    </div>
  )
}