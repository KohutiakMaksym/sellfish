import $api from "../http";
import {AxiosResponse} from "axios";

export default class AuthService {
    static async login(email, password): Promise<AxiosResponse> {
        return $api.post('/login', {email, password})
    }
    static async registration(email, password): Promise<AxiosResponse> {
        return $api.post('/registration', {email, password})
    }
    static async logout(): Promise<void> {
        return $api.post('/logout')
    }

}