import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter, Editing } from 'devextreme-react/data-grid';


const Groups = () => {

    const GroupsJson = {
      'dataType="number' : '',
      'segGroupName' : '',
      'segDescription' : ''
    }
    const key = { 'segGroupName': '',}
    const [posts, setPosts] = useState([]);
    const [insertJson, setInsert] = useState(GroupsJson);
    const [updateJson, setUpdate] = useState(GroupsJson);
    const [deleteJson, setDelete] = useState(key)
    useEffect(() =>{
        fetch("https://localhost:7063/api/MvSysSegEmailGroup")
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
          keyExpr="segGroupName"
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
                <Column dataField="segCompany" dataType="number"/> 
                <Column dataField="segGroupName"/> 
                <Column dataField="segDescription"/> 
        </DataGrid>
      </div>       
  )
  
}

export default Groups ;