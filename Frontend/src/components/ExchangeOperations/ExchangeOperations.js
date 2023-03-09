import React, {useEffect, useState} from 'react';
import DataGrid, { Column, FilterRow, HeaderFilter, Editing } from 'devextreme-react/data-grid';
//import SelectBox from 'devextreme-react/select-box';
//import CheckBox from 'devextreme-react/check-box';


const ExchangeOperations = () => {

    const [posts, setPosts] = useState([]);

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
          showBorders={true}>
            <FilterRow visible={true}/>
            <HeaderFilter visible={true} />   
            <Editing
            mode="row"
            allowUpdating={true}
            allowDeleting={true}
            allowAdding={true} />    
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