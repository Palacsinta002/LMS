import React from 'react'

export default function Dashboard() {

  const borrowedBooks = [];

  return (
    <table>
      <thead>
        <tr>
          <th>Title</th>
          <th>Due Date</th>
          <th>Status</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        {borrowedBooks.map((book) => (
          <tr key={book.id}>
            <td >{book.title}</td>
            <td >{book.dueDate}</td>
            <td>
              {book.status}
            </td>
            <td>
              <button>Renew</button>
              <button >Return</button>
            </td>
          </tr>
        ))}
      </tbody>
    </table>
  )
}
