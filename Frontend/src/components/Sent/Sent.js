import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter, Editing, Popup, Form } from 'devextreme-react/data-grid';
import { Item } from 'devextreme-react/form';


const Sent = () => {
    const sJson = {
      'ssmUsername' : '', 
      'ssmSentDatetime' : '',
      'ssmSubject' : '', 
      'ssmMessage' : '',
    }
    const key = { 'SsmSentDateTime' : '',}
    const [posts, setPosts] = useState([]);
    const [insertJson, setInsert] = useState(sJson);
    const [updateJson, setUpdate] = useState(sJson);
    const [deleteJson, setDelete] = useState(key)

    useEffect(() =>{
        fetch("https://localhost:7063/api/QvSysSsmSystemMail")
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
          keyExpr="SsmSentDateTime"
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
            <Popup title="Editing Row from E-mail Sent" showTitle={true} width={700} height={525} />
            <Form>
                <Item dataField="ssmUsername"/> 
                <Item dataField="ssmSentDatetime" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Item dataField="ssmSubject"/> 
                <Item dataField="ssmMessage"/>   
            </Form>
            </Editing>    
                <Column dataField="ssmUsername"/> 
                <Column dataField="ssmSentDatetime" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Column dataField="ssmSubject"/> 
                <Column dataField="ssmMessage"/> 
                    </DataGrid>
      </div>       
  )
  
}

export default Sent ;