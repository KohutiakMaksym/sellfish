import React from 'react';
import ProductCard from "./ProductCard";

const CatalogOnMainPage = () => {
    return (
        <div>
            <h2>catalogue</h2>
            <div className="catalogOnMainPage__cards">
                <ProductCard/>
                <ProductCard/>
                <ProductCard/>
                <ProductCard/>
                <ProductCard/>
                <ProductCard/>
                <ProductCard/>
                <ProductCard/>
            </div>
        </div>
    );
};

export default CatalogOnMainPage;