import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter, Editing } from 'devextreme-react/data-grid';



const ExchangeHosts = () => {

    const HostJson = {
      'sehCompany':'', 
      'sehHost':'', 
      'sehPortFtp" dataType="number':'',
      'sehUsername':'', 
      'sehPassword':'', 
      'sehFileProtocol':'', 
      'sehUserAlt':'', 
      'sehDateAlt':''
    }
    const key = { 'sehCompany' : ''};
    
    const [posts, setPosts] = useState([]);
    const [insertJson, setInsert] = useState(HostJson);
    const [updateJson, setUpdate] = useState(HostJson);
    const [deleteJson, setDelete] = useState(key)
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
          showBorders={true}
          onRowInserting={setInsert}
          onRowInserted={console.log(insertJson.data)}
          onRowUpdating={setUpdate}
          onRowUpdated={console.log(updateJson.data)}
          onRowRemoving={setDelete}
          onRowRemoved={console.log(deleteJson.data)}
          >
            <FilterRow visible={true}/>
            <HeaderFilter visible={true} />  
            <Editing
            mode="row"
            allowUpdating={true}
            allowDeleting={true}
            allowAdding={true} />     
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