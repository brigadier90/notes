

names = ['Ali', 'Hassan', 'Hussein', 'Ahemd']

# for name in names:
# 	print(name)

#first 2 names only
for name in names[0:2]: #slice
	print(name);


#print ali black belt
for name in names:
	if name.upper() == 'ALI':
		print('{0} - black beld'.format(name))
		break