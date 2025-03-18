import React from 'react'

export default function Cards({ index, isbn, title, author }) {
  return (
    <div key={index} className="home-card">
        <div className="home-card-image">
            <img src={`http://localhost:8000/img/${isbn}`} />
        </div>
        <div className="home-card-content">
            <h2>{title}</h2>
            <h3>{author}</h3>
            <input type="button" value="Reserve" />
        </div>
    </div>
  )
}
