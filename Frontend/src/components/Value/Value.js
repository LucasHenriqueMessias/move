import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter, Editing } from 'devextreme-react/data-grid';
//import SelectBox from 'devextreme-react/select-box';
//import CheckBox from 'devextreme-react/check-box';


const Value = () => {

    const [posts, setPosts] = useState([]);

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
          showBorders={true}>
            <FilterRow visible={true}/>
            <HeaderFilter visible={true} /> 
            <Editing
            mode="row"
            allowUpdating={true}
            allowDeleting={true}
            allowAdding={true} />      
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