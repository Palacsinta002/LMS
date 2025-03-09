<<<<<<< HEAD
import { createSlice } from "@reduxjs/toolkit";

export const tokenSlice = createSlice({
    name: 'token',
    initialState: {
        value: ''
    },
    reducers: {
        setter: (state, action) => {
            state.value = action.payload;
        }
    }
});

// Export the action
export const { setter } = tokenSlice.actions;

// Export the reducer
export default tokenSlice.reducer;
=======
import { createSlice, createAsyncThunk } from "@reduxjs/toolkit";
import axios from "axios";

const token = sessionStorage.getItem("token");

export const loginUser = createAsyncThunk(
  "auth/login",
  async ({ username, password }, { rejectWithValue }) => {
    try {
      const response = await axios.post("/api/login", {
        username,
        password,
      });

      const { token, user } = response.data;

      sessionStorage.setItem("token", token);

      return { token, user };
    } catch (error) {
      return rejectWithValue(error.response.data);
    }
  }
);

export const logoutUser = createAsyncThunk("auth/logout", async () => {
  sessionStorage.removeItem("token");
  return null;
});

const initialState = {
  user: null,
  token: token || null,
  isAuthenticated: !!token,
  loading: false,
  error: null,
};
const authSlice = createSlice({
  name: "auth",
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(loginUser.pending, (state) => {
        state.loading = true;
        state.error = null;
      })
      .addCase(loginUser.fulfilled, (state, action) => {
        state.loading = false;
        state.token = action.payload.token;
        state.user = action.payload.user;
        state.isAuthenticated = true;
      })
      .addCase(loginUser.rejected, (state, action) => {
        state.loading = false;
        state.error = action.payload;
      })
      .addCase(logoutUser.fulfilled, (state) => {
        state.token = null;
        state.user = null;
        state.isAuthenticated = false;
      });
  },
});

export const loginAction = authSlice.actions;
export default authSlice.reducer;
>>>>>>> 0d84cecf17424e82cf860f3a653a686fa207ac1f
