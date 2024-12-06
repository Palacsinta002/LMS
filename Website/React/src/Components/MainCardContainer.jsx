import React from 'react'
import "../index.css"

export default function MainCardContainer() {
    return (
        <div className="card-container">
            <div className="cards">
                <i className="fa fa-bookmark"></i>
                <h2>Books</h2>
                <p>123</p>
            </div>
            <div className="cards">
                <i className="fa fa-search"></i>
                <h2>Members</h2>
                <p>123</p>
            </div>
            <div className="cards">
                <i className="fa fa-user"></i>
                <h2>Borrows</h2>
                <p>123</p>
            </div>
        </div>
    )
}
