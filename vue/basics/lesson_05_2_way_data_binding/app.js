
new Vue({

	el: '#vue-app',
	data: {
		name: '',
		age: '',
	},

	methods: {

		logName: function() {
			name = document.getElementById("name").value;
		},

		logAge: function() {
			console.log("You entered your age")
		}
	},

	

});