name = 'Ali'


# same
# def print_name():
# 	print('inside the function: {0}'.format(name))

# print_name()

# print('outside the function: {0}'.format(name))

# #different
# def print_name():
# 	name = 'Hassan'
# 	print('inside the function: {0}'.format(name))

# print_name()

# print('outside the function: {0}'.format(name))

#same: accessing global var
def print_name():
	global name 
	name = 'Hassan'
	print('inside the function: {0}'.format(name))

print_name()

print('outside the function: {0}'.format(name))
