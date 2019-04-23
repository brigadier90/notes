class Planet:

	def __init__(self, name, radius, gravity, system):
		self.name = name
		self.radius = radius
		self.gravity = gravity
		self. system = system

	def orbit(self):
		return('{0} is orbiting the {1}'.format(self.name, self.system))



naboo = Planet('Naboo', 300000, 8, 'Naboo System')

print('name: {0}'.format(naboo.name))
print('radius: {0}'.format(naboo.radius))
print('gravity: {0}'.format(naboo.gravity))
print('system: {0}'.format(naboo.system))
print(naboo.orbit())

hoth = Planet('Hoth', 20000, 5.5, 'Hoth System')

print('name: {0}'.format(hoth.name))
print('radius: {0}'.format(hoth.radius))
print('gravity: {0}'.format(hoth.gravity))
print('system: {0}'.format(hoth.system))
print(hoth.orbit())