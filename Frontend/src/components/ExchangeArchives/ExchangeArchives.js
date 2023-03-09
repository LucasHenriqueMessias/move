import React from 'react';

import DataGrid, {
  Column, FilterRow, HeaderFilter, Editing
} from 'devextreme-react/data-grid';
import CustomStore from 'devextreme/data/custom_store';
import { formatDate } from 'devextreme/localization';
//import SelectBox from 'devextreme-react/select-box';
//import CheckBox from 'devextreme-react/check-box';


class ExchangeArchives extends React.component {
   constructor(props){
    super(props);
 this.state = {
      ordersData: new CustomStore({
        key: 'sefId',
        load: () => this.sendRequest("https://localhost:7063/api/MvSysSefExchangeFile"),
        insert: (values) => this.sendRequest("https://localhost:7063/api/MvSysSefExchangeFile", 'POST', {
          values: JSON.stringify(values),
        }),
        update: (key, values) => this.sendRequest(`https://localhost:7063/api/MvSysSefExchangeFile/update/${key}`, 'PUT', {
          key,
          values: JSON.stringify(values),
        }),
        remove: (key) => this.sendRequest(`https://localhost:7063/api/MvSysSefExchangeFile/delete/${key}`, 'DELETE', {
          key,
        }),
      })
    }

   }
sendRequest(url, method = 'GET', data = {}) {
    this.logRequest(method, url, data);

    if (method === 'GET') {
      return fetch(url, {
        method,
        credentials: 'include',
      }).then((result) => result.json().then((json) => {
        if (result.ok) return json.data;
        throw json.Message;
      }));
    }

    const params = Object.keys(data).map((key) => `${encodeURIComponent(key)}=${encodeURIComponent(data[key])}`).join('&');

    return fetch(url, {
      method,
      body: params,
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded;charset=UTF-8',
      },
      credentials: 'include',
    }).then((result) => {
      if (result.ok) {
        return result.text().then((text) => text && JSON.parse(text));
      }
      return result.json().then((json) => {
        throw json.Message;
      });
    });
  }
 logRequest(method, url, data) {
    const args = Object.keys(data || {}).map((key) => `${key}=${data[key]}`).join(' ');

    const time = formatDate(new Date(), 'HH:mm:ss');
    const request = [time, method, url.slice(URL.length), args].join(' ');

    this.setState((state) => ({ requests: [request].concat(state.requests) }));
  }

  clearRequests() {
    this.setState({ requests: [] });
  }

  handleRefreshModeChange(e) {
    this.setState({ refreshMode: e.value });
  }
 render(){
  const {
    ordersData
  } = this.state
  return(
      <React.Fragment> 
        <DataGrid 
        id="gridContainer"
          noDataText='No data to display. Please check with Support team'
          dataSource={ordersData}
          keyExpr="sefId"
          filterSyncEnabled={true}
          repaintChangesOnly={true}
          highlightChanges={true}
          showBorders={true}
          >
             <FilterRow visible={true}/>
            <HeaderFilter visible={true} />
            <Editing
            mode="row"
            allowUpdating={true}
            allowDeleting={true}
            allowAdding={true} />
            
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
      </React.Fragment>       
  )
 }
}

export default ExchangeArchives ;