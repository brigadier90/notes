console.log("starting app");

//require function is available inside any node.js file

const fs = require('fs'); //fs is the file system
const os = require('os'); //another module... for example can get machine user info
const notes = require('./notes'); //custom module - './' is the current dir
const _ = require('lodash'); //include third party module

// fs.appendFile('greetings.txt', 'Hello, World', function(err) {
// 	if (err) {
// 		console.log("couldn't write to file...");
// 	}
// });

// var user = os.userInfo();
// console.log(user);

//can do. the "`" strings allow us to include js variables (templating)
// fs.appendFile('greetings.txt', `Hello, ${ user.username }, you are ${notes.age}`, function(err) {
// 	if (err) {
// 		console.log("couldn't write to file...");
// 	}
// });

// var res = notes.addNote();
// console.log(res);

// console.log("Result of add function from note:", notes.add(3,2));

//lodash has a lot of useful functions and utilities like isString() or uniq

// console.log(_.isString(true));
// console.log(_.isString("Ali"));

//uniq takes an array and removes all duplicates
var filteredArray = _.uniq(['Ali', 'Hassan', 'Ali', 'Saad']);
console.log(filteredArray)
