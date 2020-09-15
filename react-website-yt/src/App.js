//FROM VIDEO TUTORIAL "REACT WEBSITE TUTORIAL - BEGINNER REACT JS PROJECT FULLY RESPONSIVE"
//BY BRIAN DESIGN
//link: https://www.youtube.com/watch?v=I2UBjN5ER4s

import React from 'react';
import navbar from './components/navbar';
import {BrowserRouter as Router, Switch, Route} from 'react-router-dom';
import './App.css';

function App() {
  return (
    <>
      <Router>
        <navbar />
        <Switch>
          <Route path="/" exact />
        </Switch>
      </Router>
    </>
  );
}

export default App;
