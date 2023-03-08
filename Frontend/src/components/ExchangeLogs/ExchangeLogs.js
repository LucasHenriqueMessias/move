import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter } from 'devextreme-react/data-grid';
//import SelectBox from 'devextreme-react/select-box';
//import CheckBox from 'devextreme-react/check-box';


const ExchangeLogs = () => {

    const [posts, setPosts] = useState([]);

    useEffect(() =>{
        fetch("https://localhost:7063/api/QvSysSelExchangeLog")
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
          keyExpr="selId"
          filterSyncEnabled={true}
          repaintChangesOnly={true}
          highlightChanges={true}
          showBorders={true}>
            <FilterRow visible={true}/>
            <HeaderFilter visible={true} />       
                <Column dataField="selCompany"/> 
                <Column dataField="selId" dataType="number"/>
                <Column dataField="selType"/> 
                <Column dataField="selDate" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Column dataField="selMessage"/> 
                <Column dataField="selUserAlt"/> 
                <Column dataField="selDateAlt" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
        </DataGrid>
      </div>       
  )
  
}

export default ExchangeLogs ;