import React from 'react';
import "../componentsStyles.scss";
import "../buttons/buttonsStyles.scss"

export default function Login() {
    return(
        <div className="login">
            <h2 className="login__title">Log In</h2>
            <form className="loginForm">
                <label>
                    <input className="login__inp" type="text" placeholder="Login"/>
                </label>
                <label>
                    <input className="login__inp" type="password" placeholder="Password"/>
                </label>
                <div>
                    <button className="blueButton login__blueButton" type="submit">Log in</button>
                </div>
                <div className="">
                    <button className="whiteButton login__whiteButton" type="submit">Register</button>
                </div>
            </form>
        </div>
    );
};
