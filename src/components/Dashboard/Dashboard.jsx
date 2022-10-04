import React, {useState} from 'react';
import Login from "../Login/Login";


const Dashboard = () => {
    const [token, setToken] = useState();
    if (!token) {
        return <Login setToken={setToken} />
    }
    return (
        <div>
            <h2>Dashboard</h2>

        </div>
    );
};

export default Dashboard;