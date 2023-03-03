import logo from './logo.svg';
import './App.css';
import {BrowserRouter as Router, Routes, Route} from "react-router-dom"

import ExchangeArchives  from './components/ExchangeArchives/ExchangeArchives';
import ExchangeOperations from './components/ExchangeOperations/ExchangeOperations';
import ExchangeLogs from './components/ExchangeLogs/ExchangeLogs';
import Groups from './components/Groups/Groups';
import Sent from './components/Sent/Sent';
import Queue from './components/Queue/Queue';
import Procedures from './components/Procedures/Procedures';
import Exceptions from './components/Exceptions/Exceptions';
import Value from './components/Value/Value';
import  Nav  from './components/navbar/nav.js';
import  ExchangeHosts  from './components/ExchangeHosts/ExchangeHosts';
import  Home  from './components/Home/Home';

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
