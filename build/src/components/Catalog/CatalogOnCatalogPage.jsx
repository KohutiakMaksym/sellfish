import React, {useEffect, useState} from 'react';
import ProductCard from "./ProductCard";
import CatalogServices from "../../services/CatalogServices";

const CatalogOnCatalogPage = () => {
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
        <div className="CatalogOnCatalogPage">
            <h2 className="CatalogOnCatalogPage__title">catalogue</h2>
            <div className="CatalogOnCatalogPage__cards">
                {fishes?.map(fish =>
                    <ProductCard key={fish.id} card={fish}/>
                )}
            </div>

        </div>
    );
};

export default CatalogOnCatalogPage;