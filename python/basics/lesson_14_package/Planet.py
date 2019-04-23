class Planet:

	shape = 'round' #class level attributes. NOT UNIQUE TO EACH INSTANCE

	def __init__(self, name, radius, gravity, system):
		self.name = name ############Instance level atributes
		self.radius = radius
		self.gravity = gravity
		self.system = system

	def orbit(self):
		return('{0} is orbiting {1}'.format(self.name, self.system))


	@classmethod #class level method decorator
	def commons(classname): #takes class as first argument
		return 'all planets have a {0} shape'.format(classname.shape)


	@staticmethod #static method decorator - a static mthod has no access to either the instance(self) or class
	def spin(speed = '2000 mph'): #default value
		return 'The planet spins and spins at {0}'.format(speed)

