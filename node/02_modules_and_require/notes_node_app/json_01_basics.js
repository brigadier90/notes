
//CONVERTING OBJ TO STRING
var obj = {
	name: "Ali"	
};

//we can convert this to string to pass it between apps or servers etc:

var stringObj = JSON.stringify(obj);

//log to see differences
console.log(typeof stringObj);
console.log(stringObj); //automatic double quotes around attributes

console.log(typeof obj);
console.log(obj); //no double quotes around attributes

//CONVERTING STRING TO OBJECT

var personString = '{"name": "Ali", "age": 28}'; //number doesnt need double quotes

//if we get this json from a server or a text file it is useless/
//must convert it to object

var person = JSON.parse(personString);

console.log(typeof person);
console.log(person);



