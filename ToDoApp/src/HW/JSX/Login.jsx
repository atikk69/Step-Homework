import React, { useState } from 'react';
import '../CSS/Login.css';
import '@fortawesome/fontawesome-free/css/all.min.css';

export default function Login() {
    const [passwordShown, setPasswordShown] = useState(false);

    const togglePasswordVisibility = () => {
        setPasswordShown(!passwordShown);
    };

    return (
        <div className='login-surface'>
            <div className='login'>
                <span className='login-text'>Log In</span>
                <input className='ussername-input' type="text" placeholder="Username" />
                <div className="password-container">
                    <input
                        className="password-input"
                        type={passwordShown ? "text" : "password"}
                        placeholder="Password"
                    />
                    <button onClick={togglePasswordVisibility} className="toggle-button">
                        <i className={passwordShown ? "fas fa-eye-slash" : "fas fa-eye"}></i>
                    </button>
                </div>
                <button className='login-button'>Log In</button>
            </div>
        </div>
    );
}