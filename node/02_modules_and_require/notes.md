#Node has _global_ object instead _window_
#Node has _process_ object instead of _document_
    *can be used to access command line args
    *first arg is at index = 2

#Built in modules can be found [here](https://nodejs.org/api/)
	

#REQUIRE:
	##allows us to include: 
	*_third party modules_
	* _built in modules_
	* _custom modules_

	##_NOTE:_ for third party apps, should run npm init in terminalin order to create a package.json file which stores some basic info about the app. package.json is where we define the third party apps we use for our app.

#NPM:
	* --save: run npm install [package_name] --save  <-- save updates package.json file
    * -g: global: not added to project. does not install in node_modules folder
    * @: specify version in order to have same version as tutorial

##LODASH:
        includes many functions and utilities which makes js dev much easiser.

##Nodemon
        watches app for changes and restarts app when changes occur

##yargs
        allows us to access things like title and body information without needing to write our own parser



