import { Link, useMatch, useResolvedPath } from "react-router-dom"

export default function Navbar() {
    return (
        <nav className="nav">
            <Link to="/" className="site-title">
                SellFish
            </Link>
            <ul className="main_menu">
                <CustomLink to="/catalogPage">Catalog</CustomLink>
                <CustomLink to="/cartPage">Cart</CustomLink>
                <CustomLink to="/logPage">Login/Logout</CustomLink>
                <CustomLink to="/userPage">User</CustomLink>
            </ul>
        </nav>
    )
}

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