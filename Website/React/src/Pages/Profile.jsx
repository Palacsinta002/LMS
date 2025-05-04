import React, { useEffect, useState } from 'react'
import { useLocation, useNavigate } from 'react-router-dom'
import axios from 'axios';
import { jwtDecode } from 'jwt-decode';

export default function Profile() {
  const location = useLocation();
  const navigate = useNavigate();
  const hidden = location.pathname === '/dashboard/profile' ? '' : 'hidden';

  const token = sessionStorage.getItem("token");
  const decoded = jwtDecode(token);
  const userID = decoded.userID;

  const [data, setData] = useState([]);
  const [loading, setLoading] = useState(false);
  const [deleteLoading, setDeleteLoading] = useState(false);
  const [error, setError] = useState("");
  const [showDeleteConfirmation, setShowDeleteConfirmation] = useState(false);

  const [formData, setFormData] = useState({
    firstname: "",
    lastname: "",
    username: "",
    dateOfBirth: "",
    address: "",
    currentPassword: "",
    newPassword: "",
    newPasswordAgain: ""
  });
  useEffect(() => {
    fetchUserData();
  }, [token]);

  const fetchUserData = async () => {
    try {
      const response = await axios.get("/api/user", {
        headers: {
          "Content-type": "application/json",
          "Authorization": `Bearer ${token}`
        }
      });
  
      setData(response.data);
      
      if (response.data.length > 0) {
        const userData = response.data[0];
        const formattedDate = userData.DateOfBirth ? new Date(userData.DateOfBirth).toISOString().split('T')[0] : "";
  
        setFormData(prevFormData => ({
          ...prevFormData,
          firstname: userData.firstname,
          lastname: userData.lastname,
          username: userData.username,
          dateOfBirth: formattedDate,
          address: userData.address,
        }));
        
      }
    } catch (error) {
      console.error("Error fetching user data:", error);
      setError("Failed to load user data");
    }
  };

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setFormData(prev => ({
      ...prev,
      [name]: value
    }));
  };

  async function handleSubmit(e) {
    e.preventDefault();
    setLoading(true);
    setError("");

    if (formData.newPassword && formData.newPassword !== formData.newPasswordAgain) {
      setLoading(false);
      setError("The new passwords don't match!");
      return;
    }
  
    try {
      const updateData = {
        firstname: formData.firstname,
        lastname: formData.lastname,
        dateOfBirth: formData.dateOfBirth,
        address: formData.address,
      };
  
      if (formData.username !== data[0]?.username) {
        updateData.username = formData.username;
      }
  
      if (formData.currentPassword && formData.newPassword) {
        updateData.passwordOld = formData.currentPassword;
        updateData.password = formData.newPassword;
      }
  
      const response = await axios.put("/api/user", updateData, {
        headers: {
          "Content-type": "application/json",
          "Authorization": `Bearer ${token}`,
        },
      });
  
      if (response.data.Success) {
        await fetchUserData();
        setError("");
        alert("Profile updated successfully!");
      } else {
        setError(response.data.message || "Update failed!");
      }
    } catch (error) {
      console.error("Update error:", error);
      if (error.response?.data?.message?.includes("username")) {
        setError("Username already taken. Please choose another one.");
      } else {
        setError(error.response?.data?.message || "Update error!");
      }
    } finally {
      setLoading(false);
    }
  }

  const handleDeleteAccount = async () => {
    setDeleteLoading(true);
    setError("");

    try {
      const response = await axios.delete("/api/user", {
        headers: {
          "Content-type": "application/json",
          "Authorization": `Bearer ${token}`
        },
        data: {
          userID: userID
        }
      });

      if (response.data.Success) {
        sessionStorage.removeItem("token");
        navigate("/");
        window.location.reload();
      } else {
        setError(response.data.message || "Account deletion failed");
      }
    } catch (error) {
      console.error("Deletion error:", error);
      setError(error.response?.data?.message || "Error deleting account. Please try again.");
    } finally {
      setDeleteLoading(false);
      setShowDeleteConfirmation(false);
    }
  };

  return (
    <div className={hidden}>
      {data.map((item, index) => (
        <form onSubmit={handleSubmit} key={index} className="profile-box">
          <label>First name:</label>
          <input
            className='profile-firstname'
            name="firstname"
            value={formData.firstname}
            onChange={handleInputChange}
            type="text"
          />

          <label>Last name:</label>
          <input
            className='profile-lastname'
            name="lastname"
            value={formData.lastname}
            onChange={handleInputChange}
            type="text"
          />

          <label>Username:</label>
          <input
            className='profile-username'
            name="username"
            value={formData.username}
            onChange={handleInputChange}
            type="text"
          />

          <label>Date of Birth:</label>
          <input
            className='profile-username'
            name="dateOfBirth"
            value={formData.dateOfBirth || ""}
            onChange={handleInputChange}
            type="date"
          />

          <label>Address:</label>
          <input
            className='profile-username'
            name="address"
            value={formData.address}
            onChange={handleInputChange}
            type="text"
          />

          <label>Current Password:</label>
          <input
            className='profile-password'
            name="currentPassword"
            value={formData.currentPassword}
            onChange={handleInputChange}
            type="password"
          />

          <label>New Password:</label>
          <input
            className='profile-password'
            name="newPassword"
            value={formData.newPassword}
            onChange={handleInputChange}
            type="password"
          />

          <label>New Password Again:</label>
          <input
            className='profile-password'
            name="newPasswordAgain"
            value={formData.newPasswordAgain}
            onChange={handleInputChange}
            type="password"
          />

          {error && <div className="error-message">{error}</div>}

          <div className="profile-actions">
            <input
              type="submit"
              className="profile-submit"
              value={loading ? "Saving changes..." : "Save"}
              disabled={loading}
            />
          </div>

          <button
            type="button"
            className="delete-account-button"
            onClick={() => setShowDeleteConfirmation(true)}
          >
            Delete Account
          </button>
        </form>
      ))}

      {showDeleteConfirmation && (
        <div className="confirmation-modal">
          <div className="modal-content">
            <h3>Confirm Account Deletion</h3>
            <p>Are you sure you want to permanently delete your account? All your data will be lost.</p>
            <div className="modal-actions">
              <button
                className="confirm-delete-button"
                onClick={handleDeleteAccount}
                disabled={deleteLoading}
              >
                {deleteLoading ? "Deleting..." : "Yes, Delete My Account"}
              </button>
              <button
                className="cancel-delete-button"
                onClick={() => setShowDeleteConfirmation(false)}
                disabled={deleteLoading}
              >
                Cancel
              </button>
            </div>
          </div>
        </div>
      )}
    </div>
  )
}