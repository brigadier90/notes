# fam = {'ali': 27, 'ryan': 8}

# print(fam)
# print(fam['ryan'])

# print('ryan' in fam )

# keys = list(fam.keys()) #fam.keys returns a data type called dic_keys

# print(fam.keys())
# print(keys)

# vals = list(fam.values())

# print(fam.values())
# print(vals)

# fam['ali'] = 28
# print(fam['ali'])

# #count how many ppl are 8
# print(vals.count(8)) #this is a list fucntion


# #another way to define dicts
# person = dict(name='ali', age=27, height=172)
# print(person)

#program to add ninjas and print them

def print_ninjas(dictionary):
	for key, value in dictionary.items():
		print('My name is {0} and I am a {1} belt.'.format(key, value))

ninjas = {}

while True:
	print(ninjas)

	ninja_name = raw_input('enter name: ')
	ninja_belt = raw_input('enter belt color: ')

	#add ninja to list
	ninjas[ninja_name] = ninja_belt

	cont = raw_input('another? ')

	if cont == 'y':
		continue
	else:
		break


print_ninjas()











