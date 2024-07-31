import { createSlice } from '@reduxjs/toolkit';

const cartSlice = createSlice({
  name: 'cart',
  initialState: {
    items: [],
  },
  reducers: {
    addToCart(state, action) {
      const product = action.payload;
      const existingProduct = state.items.find(item => item.id === product.id);
      if (existingProduct) {
        existingProduct.quantity += 1; // Увеличиваем количество, если продукт уже в корзине
      } else {
        state.items.push({ ...product, quantity: 1 }); // Добавляем продукт с количеством 1, если его нет в корзине
      }
    },
    removeFromCart(state, action) {
      const productId = action.payload;
      state.items = state.items.filter(item => item.id !== productId); // Удаляем продукт по ID
    },
    updateQuantity(state, action) {
      const { id, quantity } = action.payload;
      const existingProduct = state.items.find(item => item.id === id);
      if (existingProduct) {
        existingProduct.quantity = quantity; // Обновляем количество продукта
      }
    },
  },
});

export const { addToCart, removeFromCart, updateQuantity } = cartSlice.actions;
export default cartSlice.reducer;
