
prizes = [ 10, 50, 200, 300, 500]

#if we want to double all prizes

#METHOD 1: 

# dbl_prizes = []

# for p in prizes:
# 	dbl_prizes.append(2*p)

# print dbl_prizes

# METHOD 2: LIST COMPREHESNION MENTHOD
# dbl_prizes = [p * 2 for p in prizes] 
# print(dbl_prizes)



#SQUARING EVEN NUMBERS WITH LIST COMPREHENSION

nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

nums_even_squared = [n ** 2 for n in nums if (n ** 2 % 2 == 0)]

print(nums_even_squared)