
new Vue({

	el: '#vue-app',
	data: {
		age: 20,
		a: 0,
		b: 0,
	},

	methods: {
		


	},

	computed: {
		addToA: function() {
			return this.a + this.age;
		},

		addToB: function() {
			return this.b + this.age;
		},
	},

	

});