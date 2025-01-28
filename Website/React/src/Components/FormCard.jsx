import React from 'react'

export default function FormCard({ className, label, type, onChange }) {
  return (
    <div className={className}>
      <label>{label}</label>
      <input type={type} onChange={onChange}/>
    </div>
  )
}
