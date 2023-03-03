import axios from 'axios';
import React, {useEffect, useState} from 'react';
const ExchangeOperations = () => {


const [posts, setPosts] = useState([]);

    useEffect(() =>{
        axios.get("https://localhost:7063/api/MvSysSeoExchangeOperation")
        .then(response =>{
            console.log(response.data)
        })
        .catch(error => console.log(error))
    },[])
 
return(<div>ExchangeOperations</div>)
}
export default ExchangeOperations;