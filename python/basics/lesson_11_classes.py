

class Planet:

	def __init__(self): #runs when we create an instance of this class- attaches properties to object
		self.name = 'Hoth' 
		self.radius = '200000'
		self.gravity = 5.5
		self.system = 'Hoth System'


	#adding a function
	def orbit(self): # MUST ALWAYS PASS SELF TO ALL FUNCTIONS
		return '{0} is orbiting in the {1}'.format(self.name, self.system)


hoth = Planet()

print('name: {0}'.format(hoth.name))
print('radius: {0}'.format(hoth.radius))
print('gravity: {0}'.format(hoth.gravity))
print('system: {0}'.format(hoth.system))
print(hoth.orbit())

#problem: any new instance will have same properties - see lesson 12_init_function