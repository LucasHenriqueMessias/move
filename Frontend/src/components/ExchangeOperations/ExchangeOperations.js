import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter, Editing, Popup, Form } from 'devextreme-react/data-grid';
import { Item } from 'devextreme-react/form';

const ExchangeOperations = () => {

  const OperationJSON = {
    'seoCompany' : '', 
    'seoSourceHost' : '', 
    'seoDestHost' : '', 
    'seoOperation' : '', 
    'seoUserAlt' : '', 
    'seoDateAlt' : '',
    'seoDescription' : '', 
    'seoSourceFtpUser' : '', 
    'seoDestFtpUser' : ''
  }
  const key = { 'seoOperation': ''}

    const [posts, setPosts] = useState([]);
    const [insertJson, setInsert] = useState(OperationJSON);
    const [updateJson, setUpdate] = useState(OperationJSON);
    const [deleteJson, setDelete] = useState(key)
    useEffect(() =>{
        fetch("https://localhost:7063/api/MvSysSeoExchangeOperation")
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
          keyExpr="seoOperation"
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
            <Popup title="Editing Row from Exchange Operations" showTitle={true} width={700} height={525} />
            <Form>
                <Item dataField="seoCompany"/> 
                <Item dataField="seoSourceHost"/> 
                <Item dataField="seoDestHost"/> 
                <Item dataField="seoOperation"/> 
                <Item dataField="seoUserAlt"/> 
                <Item dataField="seoDateAlt" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Item dataField="seoDescription"/> 
                <Item dataField="seoSourceFtpUser"/> 
                <Item dataField="seoDestFtpUser"/> 
            </Form>
            </Editing>
                <Column dataField="seoCompany"/> 
                <Column dataField="seoSourceHost"/> 
                <Column dataField="seoDestHost"/> 
                <Column dataField="seoOperation"/> 
                <Column dataField="seoUserAlt"/> 
                <Column dataField="seoDateAlt" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Column dataField="seoDescription"/> 
                <Column dataField="seoSourceFtpUser"/> 
                <Column dataField="seoDestFtpUser"/> 
        </DataGrid>
      </div>       
  )
  
}

export default ExchangeOperations ;