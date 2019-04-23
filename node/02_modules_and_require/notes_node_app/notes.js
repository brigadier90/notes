console.log("starting notes.js");

var addNote = (title, body) => {
	console.log('Adding Note', title, body);
};

var getAll = () => {
	console.log('getting all notes');
};

var getNote = (title) => {
	console.log('getting note', title);
};

var removeNote = (title) => {
	console.log('removing note', title);
};


//can set entire object attributes to exports
module.exports = {
	//addNote: addNote (same) (if key and val are the same can leave out val - this is ES6)
	addNote, 
	getAll,
	getNote, 
	removeNote
};