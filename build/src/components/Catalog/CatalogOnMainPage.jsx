/*
import React, {useEffect, useState} from 'react';
import ProductCard from "./ProductCard";
import CatalogServices from "../services/CatalogServices";
import ButtonCard from "./ButtonCard";

const CatalogOnMainPage = () => {
    const [fishes, setFishes] = useState();
    async function getCatalog(){
        try {
            const response = await CatalogServices.fetchCatalog();
            setFishes(response.data);
        } catch (e) {
            console.log('help');
        }
    }
    useEffect(()=> {
        getCatalog();

    },[])
    return (
        <div className="catalog">
            <h2 className="catalog__title">catalogue</h2>
            <div className="catalog__cards">
                {fishes?.map((fish, i) => {
                    if (i<7)
                    return (
                        <ProductCard key={fish.id} card={fish}/>
                        )}
                )}
                <ButtonCard/>
            </div>

        </div>
    );
};

export default CatalogOnMainPage;

*/
