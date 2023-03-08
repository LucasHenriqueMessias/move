import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter } from 'devextreme-react/data-grid';
//import SelectBox from 'devextreme-react/select-box';
//import CheckBox from 'devextreme-react/check-box';


const Exceptions = () => {

    const [posts, setPosts] = useState([]);

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
          showBorders={true}>
            <FilterRow visible={true}/>
            <HeaderFilter visible={true} />       
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