import React from 'react'

export default function Cards({ index, isbn, title, author }) {
  return (
    <div key={index} className="home-card">
        <div className="home-card-image">
            <img src={`http://localhost:8000/img/${isbn}`} />
        </div>
        <div className="home-card-content">
            <h1>{title}</h1>
            <h2>{author}</h2>
            <input type="button" value="Reserve" />
        </div>
    </div>
  )
}
