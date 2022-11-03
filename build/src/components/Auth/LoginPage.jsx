import React, { Component } from "react";
import { postDataForLogin } from "../services/AccessAPI";
import SessionManager from "./SessionManager";
import { toast, ToastContainer } from "react-toastify";
import "../componentsStyles.scss";
import "../buttons/buttonsStyles.scss";

export default class Login extends Component {
    constructor() {
        super();
        this.state = {
            userName: "",
            password: "",
            loading: false,
            failed: false,
            error: ''
        };

        this.login = this.login.bind(this);
        this.onChange = this.onChange.bind(this);
    }


    onChange(e) {
        this.setState({ [e.target.name]: e.target.value });
    }

    onKeyDown = (e) => {
        if (e.key === 'Enter') {
            this.login();
        }
    }

    login() {
        let userInfo = this.state;
        this.setState({
            loading: true
        });

        //console.log("login info: " + userInfo.password);
        postDataForLogin('api/Auth/Auth', userInfo).then((result) => {
            if (result?.token) {

                SessionManager.setUserSession(result.userName, result.token, result.userId, result.usersRole)

                if (SessionManager.getToken()) {
                    this.setState({
                        loading: false
                    });

                    // <LoginMenu menuText = 'Logout' menuURL = '/logout' />

                    // If login successful and get token
                    // redirect to dashboard
                    window.location.href = "/home";
                }
            }

            else {
                let errors = '';
                for (const key in result?.errors) {
                    if (Object.hasOwnProperty.call(result.errors, key)) {
                        errors += result.errors[key];

                    }
                }
                errors = errors === '' ? 'Auth is unsuccessfully!' : errors;
                toast.error(errors, {
                    position: "top-right",
                    autoClose: 5000,
                    hideProgressBar: true,
                    closeOnClick: true,
                    pauseOnHover: true,
                    draggable: true
                });

                this.setState({
                    errors: "Auth failed!",
                    loading: false
                });
            }

        });
    }

    registration(){
        window.location.href = "/admin/user/register";

    }

    render() {
        let content;
        if (this.state.loading) {
            content = <div>Loading...</div>;
        }

        return (
            <div className="login">
                <h2 className="login__title">Log In</h2>
                    <div className="loginForm">
                        <div className="form-group has-feedback">
                            <input
                                type="text"
                                className="login__inp"
                                placeholder="Email"
                                name="userName"
                                onChange={this.onChange}
                                onKeyDown={this.onKeyDown}
                            />
                            <span className="glyphicon glyphicon-user form-control-feedback" />
                        </div>
                        <div className="form-group has-feedback">
                            <input
                                type="password"
                                className="login__inp"
                                placeholder="Password"
                                name="password"
                                onChange={this.onChange} onKeyDown={this.onKeyDown}
                            />
                            <span className="glyphicon glyphicon-lock form-control-feedback" />
                        </div>
                        <div>
                            <div>
                                <button className="blueButton login__blueButton" onClick={this.login}>
                                    Sign In
                                </button>
                            </div>
                            <div>
                                <button className="whiteButton login__whiteButton" onClick={this.registration}>
                                    Create an account
                                </button>
                            </div>
                            <div>
                                {content}
                            </div>
                        </div>
                        <div>
                            <strong>{this.state.errorMsg}</strong>
                        </div>
                    </div>
            </div>
        );
    }
}



/*
import React from 'react';
import "../componentsStyles.scss";
import "../buttons/buttonsStyles.scss";
import {Link, useMatch, useResolvedPath} from "react-router-dom";

import LoginForm from "./LoginForm";

export default function LoginPage() {
    return(
        <div className="login">
            <LoginForm/>
            <div>
                <CustomLink to="/register" className="whiteButton login__whiteButton">Register</CustomLink>
            </div>
        </div>
    );
};
function CustomLink({ to, children, ...props }) {
    const resolvedPath = useResolvedPath(to)
    const isActive = useMatch({ path: resolvedPath.pathname, end: true })

    return (
        <li className={isActive ? "active" : ""}>
            <Link to={to} {...props}>
                {children}
            </Link>
        </li>
    )
}*/
