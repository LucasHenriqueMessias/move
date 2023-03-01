import 'devextreme/dist/css/dx.light.css';
import React from 'react';
import {Home, ExchangeHosts, ExchangeOperations, ExchangeLogs, Groups, Sent, Queue, Procedures, Exceptions, Value, ExchangeArchives} from './pages';
import {BrowserRouter as Router, Routes, Route} from "react-router-dom";
import {Nav} from './layout'

function App() {
  return (
    
      <Router>
        <Nav/>
        <Routes>
          <Route path="/"element={<Home/>}/>
          <Route path="/ExchangeFiles/Arquivos" element={<ExchangeArchives/>}/>
          <Route path="/ExchangeFiles/Hosts" element={<ExchangeHosts/>}/>
          <Route path="/ExchangeFiles/Operacoes" element={<ExchangeOperations/>}/>
          <Route path="/ExchangeFiles/Logs" element={<ExchangeLogs/>}/>
          <Route path="/Email/Grupos" element={<Groups/>}/>
          <Route path="/Email/Enviados" element={<Sent/>}/>
          <Route path="/Manager/Queue" element={<Queue/>}/>
          <Route path="/Manager/Procedures" element={<Procedures/>}/>
          <Route path="/Excecoes/Excecoes" element={<Exceptions/>}/>
          <Route path="/Excecoes/ExcecaoValor" element={<Value/>}/>
        </Routes>
      </Router>    
    
   
  );
}

export default App;

