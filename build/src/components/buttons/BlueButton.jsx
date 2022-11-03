import React from 'react';
import "./buttonsStyles.scss"
import "../Catalog/catalogStyles.scss"

const BlueButton = (props) => {
    if (props.name!=null)
        return (
            <button className="buttonCard__blueButton">{props.name}</button>
        )
    else
        return (
            <button className="blueButton">Buy now</button>
        );
};

export default BlueButton;