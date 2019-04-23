import React, { Component } from 'react';

const UserInput = (props) => {

    return (

      <input type="text" onChange={props.changeUserNameHandler} value = {props.username}/>

    );
  
}

export default UserInput;

