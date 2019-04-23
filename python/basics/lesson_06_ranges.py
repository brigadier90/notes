

# print 0 to n-1 numbers


n = 100

# for i in range(n):
# 	print(i)

#print 0 to n

# for i in range(0,n+1):
# 	print i


#step by 4

# for i in range(0, n+1, 4):
# 	print(i)

#print all elements in array
burgers = ['chicken', 'cheese', 'supreme', 'double cheese', 'cordon blues']

# for n in range(0, len(burgers)):
# 	print('{0} - {1}'.format(n + 1, burgers[n]))


#backwards

for n in range(len(burgers) - 1, -1, -1): #from 4 to -1 excluding -1
	print('{0} - {1}'.format(n + 1, burgers[n]))
