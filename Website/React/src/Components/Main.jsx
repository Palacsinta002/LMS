import React from 'react'
import "../index.css"
import Pingvin from "../Images/Pingvin.jpg"

export default function Main() {
  return (
    <main>
        <div className="card-container">
            <div className="cards">
                <img src={Pingvin} alt=""/>
                <h2>Books</h2>
                <p>123</p>
            </div>
            <div className="cards">
                <img src={Pingvin} alt=""/>
                <h2>Members</h2>
                <p>123</p>
            </div>
            <div className="cards">
                <img src={Pingvin} alt=""/>
                <h2>Borrows</h2>
                <p>123</p>
            </div>
        </div>
        <table>
            <caption>Top Borrowed Books</caption>
            <thead>
                <th>Author</th>
                <th>Title</th>
                <th>Borrows</th>
            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>1</td>
                    <td>1</td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>2</td>
                    <td>2</td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>3</td>
                    <td>3</td>
                </tr>
                <tr>
                    <td>4</td>
                    <td>4</td>
                    <td>4</td>
                </tr>
                <tr>
                    <td>5</td>
                    <td>5</td>
                    <td>5</td>
                </tr>
            </tbody>
        </table>
        <div className="Browse">
            <a href="">
                <p>Browse books</p>
                <i class="fa fa-caret-down"></i>
            </a>
        </div>
    </main>
  )
}
