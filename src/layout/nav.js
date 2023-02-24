import React  from "react";
import SchaefflerLogo from '../img/cc2197bc1be13300a810520e6e4bcbc4.iix'


const Nav = () => (
<nav className="navbar navbar-expand-lg bg-light">
  <div className="container-fluid">
    
    <a className="navbar-brand" href="/"><img src={SchaefflerLogo} alt="Schaeffler"></img></a>
    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent"
      aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span className="navbar-toggler-icon"></span>
    </button>
    <div className="collapse navbar-collapse" id="navbarSupportedContent">
      <ul className="navbar-nav me-auto mb-2 mb-lg-0">
        
        <li className="nav-item dropdown">
          <a className="nav-link dropdown-toggle" href="" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Exchange Files
          </a>
          <ul className="dropdown-menu">
            <li><a className="dropdown-item" href="/ExchangeFiles/Arquivos">Arquivos do Exchange Files</a></li>
            <li><hr className="dropdown-divider"/></li>
            <li><a className="dropdown-item" href="/ExchangeFiles/Hosts">Hosts do Exchange Files Service</a></li>
            <li><hr className="dropdown-divider"/></li>
            <li><a className="dropdown-item" href="/ExchangeFiles/Operacoes">Operações do Exchange Files Service</a></li>
            <li><hr className="dropdown-divider"/></li>
            <li><a className="dropdown-item" href="/ExchangeFiles/Logs">Logs Exchange Files Service</a></li>
          </ul>
        </li>
        <li className="nav-item dropdown">
          <a className="nav-link dropdown-toggle" href="" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            E-mail
          </a>
          <ul className="dropdown-menu">
            <li><a className="dropdown-item" href="/Email/Grupos">Grupos de E-mail</a></li>
            <li>
              <hr className="dropdown-divider"/>
            </li>
            <li><a className="dropdown-item" href="/Email/Enviados">E-mails Enviados Pelo Sistema</a></li>
          </ul>
        </li>
        <li className="nav-item dropdown">
          <a className="nav-link dropdown-toggle" href="" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Queue Manager
          </a>
          <ul className="dropdown-menu">
            <li><a className="dropdown-item" href="/Manager/Queue">Queue Manager</a></li>
            <li>
              <hr className="dropdown-divider"/>
            </li>
            <li><a className="dropdown-item" href="/Manager/Procedures">Procedures</a></li>
          </ul>
        </li>

        <li className="nav-item dropdown">
          <a className="nav-link dropdown-toggle" href="" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Exceções
          </a>
          <ul className="dropdown-menu">
            <li><a className="dropdown-item" href="/Excecoes/Excecoes">Exceções</a></li>
            <li>
              <hr className="dropdown-divider" />
            </li>
            <li><a className="dropdown-item" href="/Excecoes/ExcecaoValor">Exceção x Valor</a></li>
          </ul>
        </li>
      </ul>
    </div>
  </div>
</nav>
);

export default Nav;