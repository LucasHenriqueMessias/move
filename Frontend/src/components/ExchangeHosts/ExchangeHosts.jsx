import axios from 'axios';
import React, {useEffect, useState} from 'react';

const ExchangeHosts = () => {

    const [posts, setPosts] = useState([]);

    useEffect(() =>{
        axios.get("https://localhost:7063/api/MvSysSehExhangeHost")
        .then(response =>{
            console.log(response.data)
        })
        .catch(error => console.log(error))
    },[])
 
return(<div>ExchangeHosts</div>)
}

export default ExchangeHosts;