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
}