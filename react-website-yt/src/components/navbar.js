import React, {useState} from 'react';
import {Link} from 'react-router-dom';

function navbar() {
     return (
          <>
               <nav className = "navbar">
                    <div className="navbar-container">
                         <Link to="/" className="navbar-logo"> 
                              TRVL
                         </Link>
                         <div className='menu-icon'>
                              <i className={click ? 'fas fa-times' : 'fas fa-bars'}></i>
                         </div>
                    </div>
               </nav>
          </>
     )
}

export default navbar
