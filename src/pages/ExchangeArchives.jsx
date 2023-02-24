import axios from 'axios';
import React, {useEffect, useState} from 'react';


const ExchangeArchives = () => {

    useEffect(() => {
        axios.get("https://localhost:7063/api/MvSysSefExchangeFile")
        .then(response =>{
            console.log(response.data)
        })
        .catch(error => console.log(error))
    }, [])

return(<div>ExchangeArchives</div>)

}

export default ExchangeArchives ;