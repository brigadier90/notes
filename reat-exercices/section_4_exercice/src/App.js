import React, { Component } from 'react';
import logo from './logo.svg';
import ValidationComponent from './Validation/ValidationComponent'
import CharComponent from './Char/CharComponent'
import './App.css';

class App extends Component {

  state = {
    text: "",
    length: 0
  }

  updateLengthAndText = (event) => {

    this.setState({
      text: event.target.value,
      length: event.target.value.length
    });
  }

  deleteHandler = (index) => {
    const textArray = this.state.text.split('');
    textArray.splice(index, 1);
    const newText = textArray.join('');
    this.setState({
      text: newText
    });
  }


  render () {


    const chars = this.state.text.split('').map( (char, index) => {
        return <CharComponent char = {char} key= {index} click = {() => this.deleteHandler(index)}/>
    });

    return (
      <div className="App">
        <input type="text" onChange={this.updateLengthAndText.bind(this)} value={this.state.text}/>
        <p>Entered text: {this.state.text}</p>
        <p>Length: {this.state.length}</p>

        <ValidationComponent length = {this.state.length}/>
        {chars}

      </div>
    );
  }
}

export default App;
