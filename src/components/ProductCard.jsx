import React from 'react';
import BlueButton from "./buttons/BlueButton";
import WhiteButton from "./buttons/WhiteButton";
import "./componentsStyles.scss"

const ProductCard = () => {
    return (
        <div className="productCard">
            <h3 className="productCard__title">Mackerel</h3>
            <p className="productCard__description">Sustainable Scottish mackerel caught by our responsible sourced fishing fleet in the rich fish grounds around Scotland.</p>
            <p className="productCard__price"><span>$6.5</span>/1kg</p>
            <div className="productCard__buttons">
                <BlueButton/>
                <WhiteButton/>
            </div>
        </div>
    );
};

export default ProductCard;