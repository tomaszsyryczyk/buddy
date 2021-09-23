import './App.css';
import React from 'react';
import Stocks from './Pages/Stocks/Stocks';

class App extends React.Component{
  render(){
    return (
      <div className="App">
        <Stocks></Stocks>
      </div>
    );
  }
}

export default App;