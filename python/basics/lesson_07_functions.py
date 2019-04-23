


def greet(name='ali', time='morning'): #we can create default values
	print('good {0} {1}'.format(time, name))

name = raw_input('enter name: ')
time = raw_input('enter time of day: ')

greet(name, time)
greet() # will default to good morning ali