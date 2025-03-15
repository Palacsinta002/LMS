import React from 'react'

export default function Cards({ index, img, title, publisher, author, publicationYear }) {
  return (
    <div key={index}>
        <div>
            <img src={`http://localhost:8000/img/${img}`} />
        </div>
        <div>
            <h1>{title}</h1>
            <h2>{author}</h2>
            <h3>{publisher}</h3>
            <h3>{publicationYear}</h3>
        </div>
    </div>
  )
}
