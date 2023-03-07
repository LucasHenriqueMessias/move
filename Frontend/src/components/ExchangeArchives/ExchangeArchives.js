import React, {useEffect, useState} from 'react';
import { json } from 'react-router-dom';
import axios from 'axios';
//DataGrid Definition 
function ExchangeArchives () {

    const [posts, setPosts] = useState([]);

    useEffect(() =>{
        axios.get("https://localhost:7063/api/MvSysSefExchangeFile")
        .then(response => response.json())
        .then(data => setPosts(data))
        .catch(error => console.log(error))
    },[])
 

  console.log(posts);
 
  return(
      <div className="ExchangeArchives">
      <p>{json.stringify(posts)}</p>
      </div>       
  )
  
}

export default ExchangeArchives ;