import axios from 'axios';
import React, {useEffect, useState} from 'react';

const Exceptions = () => {


    const [posts, setPosts ] = useState([]);
    useEffect(()=> {
        axios.get("https://localhost:7063/api/MvSysSxException")
        .then(response =>{
          //  setPosts(response.data); será usado quando os dados forem chamados para o devexpress
            console.log(response.data)
        })
        .catch(error => console.log(error))
    }, []) 
    
return(<div>
    Exceptions
</div>)
};



export default Exceptions;