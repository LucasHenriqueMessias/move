import axios from "axios";

const api = axios.create({
    baseURL: "https://localhost:7063/api/"
});

export default api;