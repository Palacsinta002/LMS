import React from 'react'
import "../index.css"

const data = [
  { author: "Author 1", title: "Title 1", borrows: 10 },
  { author: "Author 2", title: "Title 2", borrows: 20 },
  { author: "Author 3", title: "Title 3", borrows: 30 },
  { author: "Author 4", title: "Title 4", borrows: 40 },
  { author: "Author 5", title: "Title 5", borrows: 50 },
];

export default function MainTable() {
  return (
    <div>
      <table>
        <caption>Top Borrowed Books</caption>
        <thead>
          <tr>
            <th>Author</th>
            <th>Title</th>
            <th>Borrows</th>
          </tr>
        </thead>
        <tbody>
          {data.map((book, index) => (
            <tr key={index}>
              <td>{book.author}</td>
              <td>{book.title}</td>
              <td>{book.borrows}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  )
}