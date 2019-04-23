# a lambda is an inline anonymous function

nums = [1,2,3,4,5,6]

#suppose I want to map the squares

nums_squared = map(lambda n: n*n, nums) #intead of defining seperate function like before

#can pass many arguments next to n: n, x, y:

print(nums_squared) #<-type is list