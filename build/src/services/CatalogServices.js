import $api from "../http";

export default class CatalogServices {
    static async fetchCatalog(): Promise{
        return $api.get('/fish');
    }
}