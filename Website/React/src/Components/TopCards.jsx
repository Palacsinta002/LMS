import React from 'react'

export default function Cards({ index, isbn, category, title, author }) {
  return (
    <div key={index} className="slider-card">
      <div className="slider-card-image">
        <p className="slider-card-category">{category}</p>
        <img src={`http://localhost:8000/img/${isbn}`} />
      </div>
      <div className="slider-card-content">
        <div className="content-text">
          <h3>{title}</h3>
          <h4>{author}</h4>
        </div>
      </div>
    </div>
  )
}
