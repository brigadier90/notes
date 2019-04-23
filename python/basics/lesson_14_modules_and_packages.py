#to import class from another file
#from lesson_13_methods_and_attributes import Planet

#package is a collection of modules
#must have __init__.py file so python knows its a package
from lesson_14_package.Planet import Planet
from lesson_14_package.calc import planet_mass, planet_vol

naboo = Planet('Naboo', 300000, 8, 'Naboo System')

#printing class level methods
print(Planet.commons())
#instance also has access
print(naboo.commons())


#calling static method
print(Planet.spin())
print(naboo.spin())

print("Naboo's mass is {0:.5} Kg".format(planet_mass(naboo.gravity, naboo.radius)))
print("Naboo's volume is {0:.3f} m^3".format(planet_vol(naboo.radius)))