import React from 'react';
import BlueButton from "../buttons/BlueButton";
import {Link} from "react-router-dom";

const ButtonCard = () => {
    return (
        <div className="buttonCard">
            <Link to="/catalogPage">Go to Catalog</Link>
        </div>
    );
};

export default ButtonCard;

