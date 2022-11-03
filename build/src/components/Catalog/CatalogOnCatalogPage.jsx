/*
import React, {useEffect, useState} from 'react';
import ProductCard from "./ProductCard";
import "./catalogStyles.scss"

const CatalogOnCatalogPage = () => {
    const [fishes, setFishes] = useState();
    /!*async function getCatalog(){
        try {
            const response = await CatalogServices.fetchCatalog();
            setFishes(response.data);
        } catch (e) {
            console.log('help');
        }
    }
    useEffect(()=> {
        getCatalog();

    },[])*!/
    return (
        <div className="catalog">
            <h2 className="catalog__title">catalogue</h2>
            <div className="catalog__cards">
                {fishes?.map(fish =>
                    <ProductCard key={fish.id} card={fish}/>
                )}
            </div>

        </div>
    );
};

export default CatalogOnCatalogPage;*/
