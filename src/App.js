//import logo from './logo.svg';
import {Route, Routes} from "react-router-dom";
import "./Navbar"
import Navbar from "./Navbar";
import HomePage from "./pages/HomePage"
import LogPage from "./pages/LogPage";
import UserPage from "./pages/UserPage";
import CartPage from "./pages/CartPage";
import CatalogPage from "./pages/CatalogPage";

function App() {
  return (
    <div className="App">
        <Navbar/>
        <div className="container">
          <Routes>
              <Route path="/" element={<HomePage />}/>
              <Route path="/catalogPage" element={<CatalogPage />}/>
              <Route path="/cartPage" element={<CartPage />}/>
              <Route path="/logPage" element={<LogPage />}/>
              <Route path="/userPage" element={<UserPage />}/>
          </Routes>
        </div>
    </div>
  );
}

export default App;
