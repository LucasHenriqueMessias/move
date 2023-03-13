import React, {useEffect, useState} from 'react';
import '../../style.css';
import DataGrid, {
  Column, FilterRow, HeaderFilter, Editing, Popup, Form
} from 'devextreme-react/data-grid';
import 'devextreme/dist/css/dx.common.css';
import 'devextreme/dist/css/dx.light.css';

import { Item } from 'devextreme-react/form';


const ExchangeArchives = () => {
const ExchangeJSON = {
                'sefId': '',
                'sefCompany': '', 
                'sefOperation': '', 
                'sefSourceHost': '', 
                'sefSourceDir': '', 
                'sefSourceFile': '', 
                'sefDestHost': '', 
                'sefDestDir': '', 
                'sefDestFile': '', 
                'sefBackupDir': '', 
                'sefShare': '', 
                'sefDestShare': '', 
                'sefDeleteSource': '', 
                'sefAppend': '', 
                'sefUserAlt': '', 
                'sefDateAlt': '', 
                'sefSourceFtpUser': '', 
                'sefDestFtpUser': '', 
                'sefModule': ''
}
const key = { 'sefId' : ''};
      const [posts, setPosts] = useState([]);
      const [insertJson, setInsert] = useState(ExchangeJSON);
      const [updateJson, setUpdate] = useState(ExchangeJSON);
      const [deleteJson, setDelete] = useState(key)

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
            allowAdding={true}
            useIcons={true}>
            <Popup title="Editing Row from Exchange Archives" showTitle={true} width={700} height={525} />
            <Form>
                <Item dataField="sefId" dataType="number"/>
                <Item dataField="sefCompany"/> 
                <Item dataField="sefOperation"/> 
                <Item dataField="sefSourceHost"/> 
                <Item dataField="sefSourceDir"/> 
                <Item dataField="sefSourceFile"/> 
                <Item dataField="sefDestHost"/> 
                <Item dataField="sefDestDir"/> 
                <Item dataField="sefDestFile"/> 
                <Item dataField="sefBackupDir"/> 
                <Item dataField="sefShare"/> 
                <Item dataField="sefDestShare"/> 
                <Item dataField="sefDeleteSource"/> 
                <Item dataField="sefAppend"/> 
                <Item dataField="sefUserAlt"/> 
                <Item dataField="sefDateAlt" dataType="datetime" format="yyyy-mm-dd'T'hh:mm:ss"/> 
                <Item dataField="sefSourceFtpUser"/> 
                <Item dataField="sefDestFtpUser"/> 
                <Item dataField="sefModule"/> 
            </Form>
            </Editing>
                <Column dataField="sefId" dataType="number"/>
                <Column dataField="sefCompany"/> 
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