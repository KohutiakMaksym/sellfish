import axios from "axios";

export const API_URL = `https://sellfishapibuild.azurewebsites.net/`;

const $api = axios.create({
    withCredentials: true,
    BASE_URL: API_URL
})

$api.interceptors.request.use((config) => {
    config.headers.Authorization = `Bearer ${localStorage.getItem('token')}`;
    return config;
})

export default $api;