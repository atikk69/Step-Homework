import { createSlice } from "@reduxjs/toolkit";

const authSlice = createSlice({
    name: "auth",
    initialState: { 
        errors: {
            name: '',
            email: '',
            password: '',
            confirmPassword: ''
        }
    },
    reducers: {
        validateInputs: (state, action) => {
            const { name, email, password, confirmPassword } = action.payload;

            const nameRegex = /^[A-Za-z\s]+$/;
            const emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
            const passwordRegex = /^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$/;
            
            let newErrors = { name: '', email: '', password: '', confirmPassword: '' };

            if (!name) {
                newErrors.name = "Name is required.";
            } else if (!nameRegex.test(name)) {
                newErrors.name = "Name can only contain letters and spaces.";
            }

            if (!email) {
                newErrors.email = "Email is required.";
            } else if (!emailRegex.test(email)) {
                newErrors.email = "Invalid email format.";
            }

            if (!password) {
                newErrors.password = "Password is required.";
            } else if (!passwordRegex.test(password)) {
                newErrors.password = "Password must be at least 8 characters long and include at least one letter and one number.";
            }

            if (!confirmPassword) {
                newErrors.confirmPassword = "Confirm password is required.";
            } else if (password !== confirmPassword) {
                newErrors.confirmPassword = "Passwords do not match.";
            }

            state.errors = newErrors;
        }
    }
});

export const { validateInputs } = authSlice.actions;
export const selectAuth = (state) => state.auth;
export default authSlice.reducer;
