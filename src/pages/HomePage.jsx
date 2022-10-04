import React from 'react';
import "./pageStyles.scss"
import CatalogOnMainPage from "../components/CatalogOnMainPage";

const HomePage = () => {
    return (
        <div>
            <div className="mainSec">
                <h1 className="mainTitle">fishStore</h1>
                <p className="mainDesc">fresh fish for you</p>
            </div>
            <CatalogOnMainPage/>
        </div>
    );
};

export default HomePage;