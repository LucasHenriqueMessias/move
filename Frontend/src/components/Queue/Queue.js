import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter, Editing } from 'devextreme-react/data-grid';
//import SelectBox from 'devextreme-react/select-box';
//import CheckBox from 'devextreme-react/check-box';


const Queue = () => {

    const [posts, setPosts] = useState([]);

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
          showBorders={true}>
            <FilterRow visible={true}/>
            <HeaderFilter visible={true} />       
            <Editing
            mode="row"
            allowUpdating={true}
            allowDeleting={true}
            allowAdding={true} />
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