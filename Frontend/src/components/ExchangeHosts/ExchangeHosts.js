import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter } from 'devextreme-react/data-grid';
//import SelectBox from 'devextreme-react/select-box';
//import CheckBox from 'devextreme-react/check-box';


const ExchangeHosts = () => {

    const [posts, setPosts] = useState([]);

    useEffect(() =>{
        fetch("https://localhost:7063/api/MvSysSehExhangeHost")
        .then(response => response.json())
        .then(data => setPosts(data))
        .catch(error => console.log(error))
    },[])
 

 
  return(
      <div> 
        <DataGrid 
        id="gridContainer"
          noDataText='No data to display. Please check with Support team'
          dataSource={posts}
          keyExpr="sehCompany"
          filterSyncEnabled={true}
          repaintChangesOnly={true}
          highlightChanges={true}
          showBorders={true}>
            <FilterRow visible={true}/>
            <HeaderFilter visible={true} />       
                <Column dataField="sehCompany"/> 
                <Column dataField="sehHost"/> 
                <Column dataField="sehPortFtp" dataType="number"/>
                <Column dataField="sehUsername"/> 
                <Column dataField="sehPassword"/> 
                <Column dataField="sehFileProtocol"/> 
                <Column dataField="sehUserAlt"/> 
                <Column dataField="sehDateAlt" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
        </DataGrid>
      </div>       
  )
  
}

export default ExchangeHosts ;