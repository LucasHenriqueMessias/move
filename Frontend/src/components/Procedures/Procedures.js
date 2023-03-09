import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter, Editing } from 'devextreme-react/data-grid';
//import SelectBox from 'devextreme-react/select-box';
//import CheckBox from 'devextreme-react/check-box';


const Procedures = () => {

    const [posts, setPosts] = useState([]);

    useEffect(() =>{
        fetch("https://localhost:7063/api/MvSysSjJob")
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
          keyExpr="sjProcedureName"
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
                <Column dataField="sjProcedureName"/> 
                <Column dataField="sjDescription"/> 
                <Column dataField="sjUserCreated"/> 
                <Column dataField="sjDatetimeCreated" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Column dataField="sjUserUpdated"/> 
                <Column dataField="sjDatetimeUpdated" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                    </DataGrid>
      </div>       
  )
  
}

export default Procedures ;