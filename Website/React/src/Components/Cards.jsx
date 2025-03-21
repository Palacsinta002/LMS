import React from 'react'

export default function Cards({ index, isbn, category, title, author, onClick, onSubmit }) {
  return (
    <div key={index} className="home-card">
      <div className="home-card-image">
        <p className="home-card-category">{category}</p>
        <img src={`http://localhost:8000/img/${isbn}`} />
      </div>
      <div className="home-card-content">
        <div className="content-text">
          <h3>{title}</h3>
          <h4>{author}</h4>
        </div>
        <input type="button" className="home-card-content-button" value="Reserve" onClick={onClick} onSubmit={onSubmit} />
      </div>
    </div>
  )
}
