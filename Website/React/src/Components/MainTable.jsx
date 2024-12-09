import React from 'react'
import "../index.css"

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
        </div>
    )
}
