import React, { useEffect, useState } from 'react';
import axios from 'axios'; // Import axios
import "../index.css";

export default function MainTable() {
  const [data, setData] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null); // State for error handling

  useEffect(() => {
    const getData = async () => {
      try {
        const response = await axios.post("/api/topBorrowings");
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

  if (loading) {
    return <div>Loading...</div>;
  }

  if (error) {
    return <div>{error}</div>;
  }

  if (data.length === 0) {
    return <div>No data available</div>;
  }

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
  );
}
