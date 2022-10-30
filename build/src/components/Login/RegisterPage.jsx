import React from 'react';
import "../componentsStyles.scss";
import "../buttons/buttonsStyles.scss";
import {Link, useMatch, useResolvedPath} from "react-router-dom";
import RegisterForm from "./RegisterForm";

export default function RegisterPage() {
    return(
        <div className="login">
            <RegisterForm/>
            <div>
                <CustomLink to="/logPage" className="whiteButton login__whiteButton">Log in</CustomLink>
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