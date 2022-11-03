//import logo from './logo.svg';
import {Route, Routes} from "react-router-dom";

// navbar
import "./components/navbar/Navbar"
import Navbar from "./components/navbar/Navbar";

// pages
import HomePage from "./pages/HomePage"
import CartPage from "./pages/CartPage";
import CatalogPage from "./pages/CatalogPage";

//import RegisterPage from "./components/Auth/RegisterPage";
import LoginPage from "./components/Auth/LoginPage";

function App() {
  return (
      <div className="App">
        <Navbar/>
        <div className="container">
          <Routes>
            <Route path="/" element={<HomePage />}/>
            <Route path="/catalogPage" element={<CatalogPage />}/>
            <Route path="/cartPage" element={<CartPage />}/>
            <Route path="/logPage" element={<LoginPage />}/>
          </Routes>
        </div>
      </div>
  );
}

export default App;
