class Tab:
	menu = {
		'wine': 8,
		'beer': 6,
		'Whiskey': 12,
		'Vodka': 11,
		'Chicken': 5,
		'Beef': 15,
	}

	def __init__(sel):
		self.total = 0
		self.items = []


	def add(self, item):
		self.items.append(item)
		self.total += self.menu[item]

	def print_bill(self, tax, service): 
		tax = (tax/100) * self.total
		service = (service/100) * self.total
		total = self.total + tax + service

		for item in self.items:
			print('{0:20} ${1}'.format(item, self.menu[item]))

		print('{{Total:20}}: ${0:.2f}'.format(total))

t = Tab()
# t.add('wine')
# t.add('beer')
# t.add('Beef')
# t.add('Chicken')
# t.print_bill(15,10)