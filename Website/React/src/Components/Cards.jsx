import React from 'react'

export default function Cards({ index, isbn, category, title, author, setSelectedBook, handleReserve }) {
  return (
    <div key={index} className="home-card">
      <div className="home-card-image">
        <p className="home-card-category">{category}</p>
        <img src={`http://localhost:8000/img/${isbn}`} />
      </div>
      <div className="home-card-content">
        <div className="content-text">
          <h2>{title}</h2>
          <h3>{author}</h3>
        </div>
        <input type="button" className="home-card-content-button" value="Reserve" onChange={setSelectedBook} onSubmit={handleReserve} />
      </div>
    </div>
  )
}
