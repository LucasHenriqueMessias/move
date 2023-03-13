import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter, Editing } from 'devextreme-react/data-grid';



const Exceptions = () => {
    const ExceptionsJson = {
      'sxCompany' : '', 
                'sxModule' : '', 
                'sxTable' : '', 
                'sxColumn' : '', 
                'sxComparison' : '', 
                'sxValue' : '', 
                'sxDescription' : '', 
                'sxNote' : '', 
                'sxUserCreated' : '', 
                'sxDatetimeCreated' : '',
                'sxUserAltered' : '', 
                'sxDatetimeAltered' : '', 
    }
    const key = { 'sxCompany': ''}

    const [posts, setPosts] = useState([]);
    const [insertJson, setInsert] = useState(ExceptionsJson);
    const [updateJson, setUpdate] = useState(ExceptionsJson);
    const [deleteJson, setDelete] = useState(key) 

    useEffect(() =>{
        fetch("https://localhost:7063/api/MvSysSxException")
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
          keyExpr="sxCompany"
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
                <Column dataField="sxCompany"/> 
                <Column dataField="sxModule"/> 
                <Column dataField="sxTable"/> 
                <Column dataField="sxColumn"/> 
                <Column dataField="sxComparison"/> 
                <Column dataField="sxValue"/> 
                <Column dataField="sxDescription"/> 
                <Column dataField="sxNote"/> 
                <Column dataField="sxUserCreated"/> 
                <Column dataField="sxDatetimeCreated" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Column dataField="sxUserAltered"/> 
                <Column dataField="sxDatetimeAltered" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/> 
        </DataGrid>
      </div>       
  )
  
}

export default Exceptions ;