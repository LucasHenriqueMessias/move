import axios from 'axios';
import React, {useEffect, useState} from 'react';

const ExchangeLogs = () => {

const [posts, setPosts] = useState([]);

    useEffect(() =>{
        axios.get("https://localhost:7063/api/QvSysSelExchangeLog")
        .then(response =>{
            console.log(response.data)
        })
        .catch(error => console.log(error))
    },[])
 
return(<div>ExchangeLogs</div>)
}

export default ExchangeLogs;