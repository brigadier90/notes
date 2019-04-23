import time as T

age = 25
num = 0

#print 1 - 25

# while num < age:
# 	num += 1
# 	print(num)
# 	T.sleep(1)


#print even numbers from start to end but never the number never

start = 0
end = 100
never = 8

while start < end:

	if start == never:
		start += 1
		continue

	if start % 2 == 0:
		print(start)
		T.sleep(0.25)

	start += 1