import axios from 'axios';
import React, {useEffect, useState} from 'react';
import ODataStore from "devextreme/data/odata/store";
//import './ExchangeArchives.css'

import DataGrid, {
  Column,
  Grouping,
  GroupPanel,
  Pager,
  Paging,
  SearchPanel,
  Editing,
  FilterRow,
  ColumnChooser,
  dataSource
} from "devextreme-react/data-grid";

const pageSizes = [10, 25, 50, 100];

const APIdata = () => {
     //API Receive
    const [posts, setPosts ] = useState([]);

    const getPosts = async () =>{
        try {
            
           const response = await axios.get("https://localhost:7063/api/MvSysSefExchangeFile");
            
                const data = response.data;
                setPosts(data);
                console.log(data)
                return(data);
            
        } catch (error){
            console.log("erro em ExchangeArchives");
            console.log(error);
        }
    };

    useEffect(() =>{
        getPosts();
    }, []);

    
}

//DataGrid Definition 
class ExchangeArchives extends React.Component {
  constructor(props) {
    super(props);
    this.datareceive = APIdata.setPosts;
    this.state = {
      collapsed: false,
    };
    this.onContentReady = this.onContentReady.bind(this);

   
  }

render() {
  return(
      <div className="ExchangeArchives">
        <header className="ExchangeArchives-header">
          <DataGrid
            dataSource={this.datareceive}
            keyExpr="sefId"
            allowColumnReordering={true}
            rowAlternationEnabled={true}
            showBorders={true}
            onContentReady={this.onContentReady}
          >
          <Column dataField="sefCompany"/>
          <Column dataField="sefId"/>
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
          <Column dataField="sefDateAlt"/>
          <Column dataField="sefSourceFtpUser"/>
          <Column dataField="sefDestFtpUser"/>
          <Column dataField="sefModule"/>
          <Editing
            mode="popup"
            allowUpdating={true}
            allowDeleting={true}
            allowAdding={true}
          />
          <Pager allowedPageSizes={pageSizes} showPageSizeSelector={true} />
          <Paging defaultPageSize={50} />
          <FilterRow visible={true} />
          <SearchPanel visible={true} />
          <ColumnChooser enabled={true} />
        </DataGrid>
      </header>
    </div>       
  );
}
 onContentReady(e) {
    if (!this.state.collapsed) {
      e.component.expandRow(["EnviroCare"]);
      this.setState({
        collapsed: true,
      });
    }
  }
}


export default ExchangeArchives ;