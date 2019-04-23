import React, { Component } from 'react';


const CharComponent = (props) => {
	return (
		<span className="CharComponent" onClick= {props.click}>
			{props.char}
		</span>
	);
}

export default CharComponent;

