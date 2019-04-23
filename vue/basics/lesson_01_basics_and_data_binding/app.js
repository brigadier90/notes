
//every vue instance controlled independently
//can use one instance per widget (form, serach box etc)
//for now just one instance for whole app
new Vue({
	el: '#vue-app',

	//where all data (any kind) for this instance is stored
	data: {
		name: 'Ali',
		job: 'Web developer',

		//in order to use this in link must use data binding
		website: 'http:wwww.google.com',
		websiteTag: '<a href="http:wwww.google.com">Google</a>',
	},

	//vue instance can also have methods
	methods: {
		greet:function(timeOfDay) {
			//note we do not need to say this.data.name, vue takes all data properties and puts them at the top of 
			//vue instance
			return this.name + ' says: good ' + timeOfDay + '!';
		},
	},

});