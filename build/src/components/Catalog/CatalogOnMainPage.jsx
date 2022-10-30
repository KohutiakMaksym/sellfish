import React, {useEffect, useState} from 'react';
import ProductCard from "./ProductCard";
import CatalogServices from "../../services/CatalogServices";

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
        <div className="CatalogOnMainPage">
            <h2 className="catalogOnMainPage__title">catalogue</h2>
            <div className="catalogOnMainPage__cards">
                {fishes?.map((fish) => {
                        <ProductCard key={fish.id} card={fish}/>
                    }
                )}
            </div>

        </div>
    );
};

export default CatalogOnMainPage;