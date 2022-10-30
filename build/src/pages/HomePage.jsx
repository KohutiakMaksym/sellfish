import React from 'react';
import "./pageStyles.scss"
import CatalogOnMainPage from "../components/CatalogOnMainPage";

const HomePage = () => {
    return (
        <div>
            <div className="mainSec">
                <h1 className="mainTitle">fishStore</h1>
                <p className="mainDesc">fresh fish for you</p>
                <div className="svg-art">
                    <svg width="1920" height="391" viewBox="0 0 1920 391" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <path d="M-245 55.3139L-175.923 116.383C-106.847 177.451 31.3065 299.589 169.46 316.87C307.613 334.151 445.766 246.575 583.919 267.401C722.073 288.227 860.226 417.455 998.379 434.872C1136.53 452.29 1274.69 357.896 1412.84 294.641C1550.99 231.387 1689.15 199.272 1827.3 228.961C1965.45 258.65 2103.61 350.144 2241.76 386.434C2379.91 422.724 2518.06 403.81 2587.14 394.353L2656.22 384.896" stroke="#0E4DA4" stroke-width="20"/>
                        <path d="M-200.749 465.813L-149.561 453.768C-98.3734 441.723 4.0026 417.633 104.992 407.014C205.982 396.395 305.586 399.246 408.194 372.904C510.801 346.561 616.413 291.026 719.772 257.387C823.13 223.749 924.236 212.008 1023.06 222.42C1121.89 232.833 1218.43 265.4 1319.24 256.518C1420.05 247.635 1525.13 197.303 1624.17 205.624C1723.21 213.946 1816.22 280.92 1912.71 314.057C2009.19 347.193 2109.16 346.491 2210.31 334.283C2311.47 322.075 2413.81 298.36 2464.97 286.503L2516.14 274.646" stroke="#BCDBDF" stroke-width="20"/>
                        <path d="M-227.023 265.507L-178.739 286.844C-130.454 308.181 -33.8852 350.856 62.6838 369.479C159.253 388.102 255.822 382.674 352.391 364.409C448.96 346.143 545.529 315.04 642.098 312.337C738.667 309.634 835.236 335.33 931.805 364.758C1028.37 394.186 1124.94 427.346 1221.51 459.736C1318.08 492.125 1414.65 523.744 1511.22 511.866C1607.79 499.988 1704.36 444.614 1800.93 407.33C1897.49 370.046 1994.06 350.852 2090.63 379.056C2187.2 407.259 2283.77 482.859 2380.34 491.936C2476.91 501.014 2573.48 443.568 2621.76 414.845L2670.05 386.123" stroke="#F7AA00" stroke-width="20"/>
                    </svg>
                </div>

            </div>
            <CatalogOnMainPage/>
        </div>
    );
};

export default HomePage;