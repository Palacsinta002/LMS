import React from 'react'
import "../index.css"

const cardData = [
  { icon: "fa-bookmark", title: "Books", count: 123 },
  { icon: "fa-search", title: "Members", count: 123 },
  { icon: "fa-user", title: "Borrows", count: 123 },
];

export default function MainCardContainer() {
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