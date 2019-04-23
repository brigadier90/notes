
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



###################################################### move to next lesson
# naboo = Planet('Naboo', 300000, 8, 'Naboo System')

# print('name: {0}'.format(naboo.name))
# print('radius: {0}'.format(naboo.radius))
# print('gravity: {0}'.format(naboo.gravity))
# print('system: {0}'.format(naboo.system))
# print(naboo.orbit())

# hoth = Planet('Hoth', 20000, 5.5, 'Hoth System')

# print('name: {0}'.format(hoth.name))
# print('radius: {0}'.format(hoth.radius))
# print('gravity: {0}'.format(hoth.gravity))
# print('system: {0}'.format(hoth.system))
# print(hoth.orbit())


# #printing the class level attr
# print(Planet.shape)
# #instance also has access
# print(hoth.shape)



# #printing class level methods
# print(Planet.commons())
# #instance also has access
# print(naboo.commons())


# #calling static method
# print(Planet.spin())
# print(naboo.spin())
######################################################






