#SORTING

##################
# #numbers
# nums = [1, 4, 5, 6, -6, 2, 1, 1,1,1]

# nums = sorted(nums)
# print(nums)

# #strings - capital letters get sorted first
# names = ['ali', 'Ahmed', 'Brahim', 'hassan', 'Hussein', 'abbass', 'ali']
# print(sorted(names))

# #SETS

# #sets do not allow duplicates - if we typecast nums to a set all duplcates removes
# print(set(nums)) #also sets do not preserve order

# print(set(names))


##################


#example from dictionaries this time we print number of red belts/ black belts etc

def belt_colors(dictionary):
	belts = list(dictionary.values());

	for belt in set(belts): #we turn this into a set to avoid duplicates - remove typecast to see
		num = belts.count(belt)
		print('There are {0} {1} belts'.format(num, belt))

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


belt_colors(ninjas)



