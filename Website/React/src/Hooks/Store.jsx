import { configureStore } from '@reduxjs/toolkit';
<<<<<<< HEAD
import tokenReducer from './TokenSlice';
=======
import TokenSlice from './TokenSlice';
>>>>>>> 0d84cecf17424e82cf860f3a653a686fa207ac1f


export const store = configureStore({
  reducer: {
    auth: TokenSlice
  }
});

export default store;