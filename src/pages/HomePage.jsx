import React from 'react';
import "./pageStyles.scss"
import CatalogOnMainPage from "../components/CatalogOnMainPage";

const HomePage = () => {
    return (
        <div>
            <h1 className="main_title">Fish Store</h1>
            <p>fresh fish for you</p>
            <CatalogOnMainPage/>
        </div>
    );
};

export default HomePage;