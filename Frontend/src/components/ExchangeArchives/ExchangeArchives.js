import React, {useEffect, useState} from 'react';

import DataGrid, {
  Column, FilterRow, HeaderFilter,
} from 'devextreme-react/data-grid';
//import SelectBox from 'devextreme-react/select-box';
//import CheckBox from 'devextreme-react/check-box';


const ExchangeArchives = () => {

    const [posts, setPosts] = useState([]);

    useEffect(() =>{
        fetch("https://localhost:7063/api/MvSysSefExchangeFile")
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
          keyExpr="sefId"
          filterSyncEnabled={true}
          repaintChangesOnly={true}
          highlightChanges={true}
          showBorders={true}>
             <FilterRow visible={true}/>
            <HeaderFilter visible={true} />
            
            
                <Column dataField="sefCompany"/> 
                <Column dataField="sefId" dataType="number"/>
                <Column dataField="sefOperation"/> 
                <Column dataField="sefSourceHost"/> 
                <Column dataField="sefSourceDir"/> 
                <Column dataField="sefSourceFile"/> 
                <Column dataField="sefDestHost"/> 
                <Column dataField="sefDestDir"/> 
                <Column dataField="sefDestFile"/> 
                <Column dataField="sefBackupDir"/> 
                <Column dataField="sefShare"/> 
                <Column dataField="sefDestShare"/> 
                <Column dataField="sefDeleteSource"/> 
                <Column dataField="sefAppend"/> 
                <Column dataField="sefUserAlt"/> 
                <Column dataField="sefDateAlt" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/> 
                <Column dataField="sefSourceFtpUser"/> 
                <Column dataField="sefDestFtpUser"/> 
                <Column dataField="sefModule"/> 
          </DataGrid>
      </div>       
  )
  
}

export default ExchangeArchives ;