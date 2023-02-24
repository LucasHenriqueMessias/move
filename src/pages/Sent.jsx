import axios from 'axios';
import React, {useEffect, useState} from 'react';
const Sent = () => {

const [posts, setPosts ] = useState([]);
    useEffect(()=> {
        axios.get("https://localhost:7063/api/QvSysSsmSystemMail")
        .then(response =>{
          //  setPosts(response.data); será usado quando os dados forem chamados para o devexpress
            console.log(response.data)
        })
        .catch(error => console.log(error))
    }, []) 
    
return(<div>
    Sent
</div>)
}
export default Sent;