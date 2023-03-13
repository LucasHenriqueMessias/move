import React from 'react';

const Home = () => (
    <div>
        <div>
            <div className='title_section'>Exchange Files</div>
            <button>Exchange Files Archives</button>
            <button>Exchange Files Host Service</button>
            
        </div>
        <div>
            <button>Exchange Files Operations</button>
            <button>Exchange Files Logs</button>
            
        </div>
        <div>
            <div className='title_section'>E-mail</div>
            <button>E-mail Groups</button>
            <button>E-mail Sents</button>
        </div>
        <div>
            <div className='title_section'>Managers</div>
            <button>Queue Manager</button>
            <button>Procedures</button>
        </div>

        <div className='title_section'>Exceptions</div>
        <button>Exceptions</button>
        <button>Value x Exception</button>
    
    </div>
);

export default Home;