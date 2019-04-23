import React, { Component } from 'react';

const ValidationComponent = (props) => {

	const MINIMUM = 5;
	const MAXIMUM = 20;
	let text = "";

	if (props.length < MINIMUM)
		text = "text is too short, minimum length is: " + MINIMUM;
	else if (props.length > MAXIMUM)
		text = "text is too long, maximum length is: " + MAXIMUM;
	else
		text = "text length is OK!";

	return (
		<div>
			<p>{text}</p>
		</div>
	);
}

export default ValidationComponent;