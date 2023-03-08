import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter } from 'devextreme-react/data-grid';
//import SelectBox from 'devextreme-react/select-box';
//import CheckBox from 'devextreme-react/check-box';


const Sent = () => {

    const [posts, setPosts] = useState([]);

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
          showBorders={true}>
            <FilterRow visible={true}/>
            <HeaderFilter visible={true} />       
                <Column dataField="ssmUsername"/> 
                <Column dataField="ssmSentDatetime" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/>
                <Column dataField="ssmSubject"/> 
                <Column dataField="ssmMessage"/> 
                    </DataGrid>
      </div>       
  )
  
}

export default Sent ;