import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter } from 'devextreme-react/data-grid';
//import SelectBox from 'devextreme-react/select-box';
//import CheckBox from 'devextreme-react/check-box';


const Groups = () => {

    const [posts, setPosts] = useState([]);

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
          showBorders={true}>
            <FilterRow visible={true}/>
            <HeaderFilter visible={true} />       
                <Column dataField="segCompany" dataType="number"/> 
                <Column dataField="segGroupName"/> 
                <Column dataField="segDescription"/> 
        </DataGrid>
      </div>       
  )
  
}

export default Groups ;