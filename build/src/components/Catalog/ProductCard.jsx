import React from 'react';
import BlueButton from "../buttons/BlueButton";
import WhiteButton from "../buttons/WhiteButton";
import "./catalogStyles.scss"

const ProductCard = (props) => {
    /*
     {props.card?.map(fish =>
            {
                console.log( fish.fishName)
            }
            )}*/
    return (
        <div className="productCard">
            <h3>{props.card.fishName}</h3>
            <p className="productCard__description">{props.card.description}</p>
            <p className="productCard__price"><span>${props.card.fishPrice}</span>/1kg</p>
            <div className="productCard__buttons">
                <BlueButton/>
                <WhiteButton/>
            </div>
        </div>
    );
};

export default ProductCard;