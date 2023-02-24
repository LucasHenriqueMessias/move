import axios from 'axios';


var url = "https://localhost:7063/api/"
var data;
function getDataAPI(APIurl){
    url = url + APIurl;
    axios.get(url)
    .then(response =>{
        data = response.data;
        console.log(response)
    })
    .catch(error => console.log(error))
    return data;
    
}
export default getDataAPI;

