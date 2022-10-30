import React, {useState} from 'react';
import LoginPage from "../Login/LoginPage";

const Dashboard = () => {
    const [token, setToken] = useState();
    if (!token) {
        return <LoginPage setToken={setToken} />
    }
    return (
        <div>
            <h2>Dashboard</h2>

        </div>
    );
};

export default Dashboard;