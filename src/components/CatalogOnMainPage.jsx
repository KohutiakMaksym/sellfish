import React from 'react';
import ProductCard from "./ProductCard";

const CatalogOnMainPage = () => {
    return (
        <div className="CatalogOnMainPage">
            <h2 className="catalogOnMainPage__title">catalogue</h2>
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