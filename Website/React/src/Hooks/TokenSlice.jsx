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
