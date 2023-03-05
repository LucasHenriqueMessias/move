import axios from 'axios';
import React, {useEffect, useState} from 'react';
import DataGrid, {
  Column, FilterRow, HeaderFilter, SearchPanel,
} from 'devextreme-react/data-grid';
import SelectBox from 'devextreme-react/select-box';
import CheckBox from 'devextreme-react/check-box';


const ExchangeArchives = () => {

//API Receive
    const [posts, setPosts ] = useState([]);

    const getPosts = async () =>{
        try {
            
           const response = await axios.get("https://localhost:7063/api/MvSysSefExchangeFile");
            
                const data = response.data;
                setPosts(data);
                console.log(data)
            
        } catch (error){
            console.log("erro em ExchangeArchives");
            console.log(error);
        }
    };

    useEffect(() =>{
        getPosts();
    }, []);
    
    //d



//<h2>{post.sefId}</h2>
return(<div>
   
    {posts.length === 0 ? <p>carregando</p> : (
        posts.map((post) =>(
            <div className="post" key={post.sefId}>
                <h2>--------------------------------------</h2>
                <h2>Company: {post.sefCompany}</h2>
                <h2>Id: {post.sefId}</h2>
                <h2>Operation: {post.sefOperation}</h2>
                <h2>SourceHost: {post.sefSourceHost}</h2>
                <h2>SourceDir: {post.sefSourceDir}</h2>
            </div>
        ))
    ) }

</div>)

}

export default ExchangeArchives ;