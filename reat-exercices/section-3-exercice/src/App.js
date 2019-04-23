import React, { Component } from 'react';
import logo from './logo.svg';
import UserInput from './User/UserInput';
import UserOutput from './User/UserOutput';
import './App.css';

class App extends Component {

  state = {
    username: "brigadier90"
  };

  changeUserNameHandler = (event) => {
    this.setState({username: event.target.value});
  }


  render() {
    return (
      <div className="App">
        <UserInput username={this.state.username} changeUserNameHandler={this.changeUserNameHandler.bind(this)}  />
        <UserOutput username={this.state.username}/>
      </div>

    );
  }
}

export default App;
