import React from 'react'

export default function FormCard({ className, label, type }) {
  return (
    <div className={className}>
      <label>{label}</label>
      <input type={type} />
    </div>
  )
}
