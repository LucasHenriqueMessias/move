import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter, Editing, Popup, Form } from 'devextreme-react/data-grid';
import { Item } from 'devextreme-react/form';


const Queue = () => {
    const qJSON = {
      'sjqProcedureName' : '', 
      'sjDescription' : '',
      'sjqJob' : '',
      'sjqDatetimeScheduled' : '',
      'sjqStatus' : '',
      'sjqInterval' : '',
      'sjqSunday' : '',
      'sjqMonday' : '',
      'sjqTuesday' : '',
      'sjqWednesday' : '',
      'sjqThursday' : '',
      'sjqFriday' : '',
      'sjqSaturday' : '',
      'sjqMessage' : '', 
      'sjqFollowedByMail' : '',
      'sjqUserCreated' : '', 
      'sjqDatetimeCreated' : '',
      'sjqUserUpdated' : '', 
      'sjqDatetimeUpdated' : '',
      'sjqTotalIteration' : '',
      'sjqCurrentIteration' : ''
    }
    const key = { 'sjqProcedureName' : ''}
    const [posts, setPosts] = useState([]);
    
    const [insertJson, setInsert] = useState(qJSON);
    const [updateJson, setUpdate] = useState(qJSON);
    const [deleteJson, setDelete] = useState(key)

    useEffect(() =>{
        fetch("https://localhost:7063/api/MvSysSjqJobQueue")
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
          keyExpr="sjqProcedureName"
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
            <Popup title="Editing Row from Queue" showTitle={true} width={700} height={525} />
            <Form>
                <Item dataField="sjqProcedureName"/> 
                <Item dataField="sjDescription"/>
                <Item dataField="sjqJob" dataType="number"/>
                <Item dataField="sjqDatetimeScheduled" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Item dataField="sjqStatus"/>
                <Item dataField="sjqInterval"/>
                <Item dataField="sjqSunday"/>
                <Item dataField="sjqMonday"/>
                <Item dataField="sjqTuesday"/>
                <Item dataField="sjqWednesday"/>
                <Item dataField="sjqThursday"/>
                <Item dataField="sjqFriday"/>
                <Item dataField="sjqSaturday"/>
                <Item dataField="sjqMessage"/> 
                <Item dataField="sjqFollowedByMail"/>
                <Item dataField="sjqUserCreated"/> 
                <Item dataField="sjqDatetimeCreated" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Item dataField="sjqUserUpdated"/> 
                <Item dataField="sjqDatetimeUpdated" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Item dataField="sjqTotalIteration" dataType="number"/>
                <Item dataField="sjqCurrentIteration" dataType="number"/>
            </Form>
            </Editing>


                <Column dataField="sjqProcedureName"/> 
                <Column dataField="sjDescription"/>
                <Column dataField="sjqJob" dataType="number"/>
                <Column dataField="sjqDatetimeScheduled" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Column dataField="sjqStatus"/>
                <Column dataField="sjqInterval"/>
                <Column dataField="sjqSunday"/>
                <Column dataField="sjqMonday"/>
                <Column dataField="sjqTuesday"/>
                <Column dataField="sjqWednesday"/>
                <Column dataField="sjqThursday"/>
                <Column dataField="sjqFriday"/>
                <Column dataField="sjqSaturday"/>
                <Column dataField="sjqMessage"/> 
                <Column dataField="sjqFollowedByMail"/>
                <Column dataField="sjqUserCreated"/> 
                <Column dataField="sjqDatetimeCreated" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Column dataField="sjqUserUpdated"/> 
                <Column dataField="sjqDatetimeUpdated" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Column dataField="sjqTotalIteration" dataType="number"/>
                <Column dataField="sjqCurrentIteration" dataType="number"/>
                    </DataGrid>
      </div>       
  )
  
}

export default Queue ;