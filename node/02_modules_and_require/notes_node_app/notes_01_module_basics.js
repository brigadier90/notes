console.log("starting notes.js");

//inside all node.js files we have access to a var called module

//console.log(module); //mostly gonna use exports property

//can add properties to module.exports, this can be called in app.js
module.exports.age = 28;

//can also add functions
//NOTE: Arrow functions do not bind the this keyword or the arguments array. Can be used for anonymous functions though
module.exports.addNote = () => { //this is ES6, can also say .addNote = function() {};
	console.log("addNote():\n");
	return "New Note:";
};

//another example
module.exports.add = (num1, num2) => {
	return num1 + num2;
};