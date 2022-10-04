//import logo from './logo.svg';
import {Route, Routes} from "react-router-dom";
// navbar
import "./Navbar"
import Navbar from "./Navbar";
// pages
import HomePage from "./pages/HomePage"
import CartPage from "./pages/CartPage";
import CatalogPage from "./pages/CatalogPage";
//log/user page

import Dashboard from "./components/Dashboard/Dashboard";
import Preferences from "./components/Preferences/Preferences";

function App() {
    return (
        <div className="App">
            <Navbar/>
            <div className="container">
              <Routes>
                  <Route path="/" element={<HomePage />}/>
                  <Route path="/catalogPage" element={<CatalogPage />}/>
                  <Route path="/cartPage" element={<CartPage />}/>
                  <Route path="/logPage" element={<Dashboard />}/>
                  <Route path="/preferences" element={<Preferences />}/>
              </Routes>
            </div>
        </div>
  );
}

export default App;
