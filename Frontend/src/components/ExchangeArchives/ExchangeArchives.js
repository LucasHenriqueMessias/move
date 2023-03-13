import React, {useEffect, useState} from 'react';

import DataGrid, {
  Column, FilterRow, HeaderFilter, Editing
} from 'devextreme-react/data-grid';


const ExchangeArchives = () => {
const ExchangeJSON = {
                'sefId': '',
                'sefCompany': '', 
                'sefOperation': '', 
                'sefSourceHost': '', 
                'sefSourceDir': '', 
                'sefSourceFile': '', 
                'sefDestHost': '', 
                'sefDestDir': '', 
                'sefDestFile': '', 
                'sefBackupDir': '', 
                'sefShare': '', 
                'sefDestShare': '', 
                'sefDeleteSource': '', 
                'sefAppend': '', 
                'sefUserAlt': '', 
                'sefDateAlt': '', 
                'sefSourceFtpUser': '', 
                'sefDestFtpUser': '', 
                'sefModule': ''
}
const key = { 'sefId' : ''};
      const [posts, setPosts] = useState([]);
      const [insertJson, setInsert] = useState(ExchangeJSON);
      const [updateJson, setUpdate] = useState(ExchangeJSON);
      const [deleteJson, setDelete] = useState(key)

    useEffect(() =>{
        fetch("https://localhost:7063/api/MvSysSefExchangeFile")
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
          keyExpr="sefId"
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
            
                <Column dataField="sefId" dataType="number"/>
                <Column dataField="sefCompany"/> 
                <Column dataField="sefOperation"/> 
                <Column dataField="sefSourceHost"/> 
                <Column dataField="sefSourceDir"/> 
                <Column dataField="sefSourceFile"/> 
                <Column dataField="sefDestHost"/> 
                <Column dataField="sefDestDir"/> 
                <Column dataField="sefDestFile"/> 
                <Column dataField="sefBackupDir"/> 
                <Column dataField="sefShare"/> 
                <Column dataField="sefDestShare"/> 
                <Column dataField="sefDeleteSource"/> 
                <Column dataField="sefAppend"/> 
                <Column dataField="sefUserAlt"/> 
                <Column dataField="sefDateAlt" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/> 
                <Column dataField="sefSourceFtpUser"/> 
                <Column dataField="sefDestFtpUser"/> 
                <Column dataField="sefModule"/> 
          </DataGrid>
      </div>       
 )
}


export default ExchangeArchives ;