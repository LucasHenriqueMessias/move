import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter, Editing, Popup, Form } from 'devextreme-react/data-grid';
import { Item } from 'devextreme-react/form';


const Value = () => {
    const vjson = {
      'svxCompany' : '', 
      'sxDescription' : '', 
      'svxAlphanumericValue' : '', 
      'svxNumericValue' : '',
      'svxDatetimeValue' : '',
      'svxActive' : '', 
      'svxUserCreated' : '', 
      'svxDatetimeCreated' : '', 
      'svxUserAltered' : '', 
      'svxDatetimeAltered' : '',
    }
    const key = { 'svxCompany':''}
    const [posts, setPosts] = useState([]);
    const [insertJson, setInsert] = useState(vjson);
    const [updateJson, setUpdate] = useState(vjson);
    const [deleteJson, setDelete] = useState(key);

    useEffect(() =>{
        fetch("https://localhost:7063/api/MvSysSvxValueException")
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
          keyExpr="svxCompany"
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
            allowAdding={true}
            useIcons={true}>
            <Popup title="Editing Row from Exceptions x Values" showTitle={true} width={700} height={525} />
            <Form>
                <Item dataField="svxCompany"/> 
                <Item dataField="sxDescription"/> 
                <Item dataField="svxAlphanumericValue"/> 
                <Item dataField="svxNumericValue"/> 0
                <Item dataField="svxDatetimeValue" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Item dataField="svxActive"/> 
                <Item dataField="svxUserCreated"/> 
                <Item dataField="svxDatetimeCreated" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/> 
                <Item dataField="svxUserAltered"/> 
                <Item dataField="svxDatetimeAltered" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>   
            </Form>
            </Editing>
     
                <Column dataField="svxCompany"/> 
                <Column dataField="sxDescription"/> 
                <Column dataField="svxAlphanumericValue"/> 
                <Column dataField="svxNumericValue"/> 0
                <Column dataField="svxDatetimeValue" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Column dataField="svxActive"/> 
                <Column dataField="svxUserCreated"/> 
                <Column dataField="svxDatetimeCreated" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/> 
                <Column dataField="svxUserAltered"/> 
                <Column dataField="svxDatetimeAltered" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
        </DataGrid>
      </div>       
  )
  
}

export default Value ;