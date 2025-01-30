import React from 'react'

export default function FormCard({ className, label, type, onChange, placeholder }) {
  return (
    <div className={className}>
      <label>{label}</label>
      <input type={type} onChange={onChange} placeholder={placeholder}/>
    </div>
  )
}
