import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter, Editing, Popup, Form } from 'devextreme-react/data-grid';
import { Item } from 'devextreme-react/form';


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
            mode="popup"
            allowUpdating={true}
            allowDeleting={true}
            allowAdding={true}>
            <Popup title="Editing Row from Exceptions" showTitle={true} width={700} height={525} />
            <Form>
                <Item dataField="sxCompany"/> 
                <Item dataField="sxModule"/> 
                <Item dataField="sxTable"/> 
                <Item dataField="sxItem"/> 
                <Item dataField="sxComparison"/> 
                <Item dataField="sxValue"/> 
                <Item dataField="sxDescription"/> 
                <Item dataField="sxNote"/> 
                <Item dataField="sxUserCreated"/> 
                <Item dataField="sxDatetimeCreated" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Item dataField="sxUserAltered"/> 
                <Item dataField="sxDatetimeAltered" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/> 
            </Form>
            </Editing>   
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