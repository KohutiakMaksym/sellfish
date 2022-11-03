import React, {useContext, useEffect, useRef, useState} from 'react';
import {Link, useMatch, useResolvedPath} from "react-router-dom";
import "../componentsStyles.scss";
import "../buttons/buttonsStyles.scss";
//import axios from "axios";
//import { FormErrors } from './FormErrors';

const LoginForm = () => {
    //const { setAuth } = useContext(AuthContext);
    const userRef = useRef();
    const errRef = useRef();
    let your_id;
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [errMsg, setErrMsg] = useState('');
    const [success, setSuccess] = useState(false);
    const [data, setData] = useState();
    const {Store} = useContext(Context);
    useEffect(() => {
        userRef.current.focus();
    }, [])

    useEffect(() => {
        setErrMsg('');
    }, [email, password])

    return (
        <div className="login">
                    <p ref={errRef} className={errMsg ? "errmsg" : "offscreen"} aria-live="assertive">{errMsg}</p>

                    <form className="loginForm">
                        <label htmlFor="username"></label>
                        <input
                            type="email"
                            id="username"
                            placeholder="Email"
                            className={`login__inp`}
                            ref={userRef}
                            autoComplete="on"
                            onChange={(e) => setEmail(e.target.value)}
                            value={email}
                            required
                        />
                        <label htmlFor="password"></label>
                        <input
                            type="password"
                            id="password"
                            placeholder="Password"
                            className={`login__inp`}
                            onChange={(e) => setPassword(e.target.value)}
                            value={password}
                            required
                        />
                        <button
                            className="blueButton login__blueButton"

                        >
                        Sign In
                        </button>
                    </form>
                </div>
    )
}

export default LoginForm;
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
}
