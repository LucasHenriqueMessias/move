import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter, Editing } from 'devextreme-react/data-grid';
//import SelectBox from 'devextreme-react/select-box';
//import CheckBox from 'devextreme-react/check-box';


const ExchangeLogs = () => {

  const LogsJson = {
    'selCompany' : '', 
    'selId" dataType="number' : '',
    'selType' : '', 
    'selDate' : '',
    'selMessage' : '', 
    'selUserAlt' : '', 
    'selDateAlt"' : ''
  }

  const key = { 'selId': ''}
    const [posts, setPosts] = useState([]);
    const [insertJson, setInsert] = useState(LogsJson);
    const [updateJson, setUpdate] = useState(LogsJson);
    const [deleteJson, setDelete] = useState(key)
    useEffect(() =>{
        fetch("https://localhost:7063/api/QvSysSelExchangeLog")
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
          keyExpr="selId"
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
                <Column dataField="selCompany"/> 
                <Column dataField="selId" dataType="number"/>
                <Column dataField="selType"/> 
                <Column dataField="selDate" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Column dataField="selMessage"/> 
                <Column dataField="selUserAlt"/> 
                <Column dataField="selDateAlt" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
        </DataGrid>
      </div>       
  )
  
}

export default ExchangeLogs ;