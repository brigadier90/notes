# # proof that functions are objects
# x = 5

# def printAli():
# 	print("Ali")

# class Ali:
# 	pass

# #returns list of the attributes and methods of any object, pass nothing and it returns all the above
# #check out build in functions and attributes (__name__, __doc__, __module, __dict__)
# print(dir()) 

#simple example to return function as an object
# def outside():
# 	def inside():
# 		print("Ali")

# 	return inside

#if we define a variable in the outside function this time, will it print even 
#though we are no longer in outside()'s scope?
# yes, because when we define inside() it takes a 'snapshot' of all variables it has access to
# def outside():
# 	x = 5
# 	def inside():
# 		print(x)

# 	return inside

#can pass in that variable to overide it
# def outside(x = 5):
	
# 	def inside():
# 		print(x)

# 	return inside


# my_func = outside(7)

# my_func()

# #we can pass functions in as arguments
# def add_one(some_func):
# 	def add_one_inside():
# 		return some_func() + 1

# 	return add_one_inside


# def return_number():
# 	return 7

# my_func = add_one(return_number)
# print(my_func())

# #can overide return_number 
# return_number = add_one(return_number)
# print(return_number())

# #but there is an easier way!

#DECORATORS

# def add_one(some_func):
# 	def add_one_inside():
# 		return some_func() + 1

# 	return add_one_inside

# @add_one
# def return_number():
# 	return 7

# print(return_number())

#adding args and kwargs
# def add_one(some_func):
# 	def add_one_inside(*args, **kwargs):
# 		return some_func(*args, **kwargs) + 1

# 	return add_one_inside

# @add_one
# def return_number(x = 825):
# 	return x

# print(return_number(x = 777))

#NOTE: WE EESSENTIALY TURN FUNCTION INTO INSIDE FUNCTION UNTIL NOW

#example can use decorators to make sure args are correct; factorial function cannot take neg numbers
#or floats

def argument_test_natural_number(f):
    def helper(x):
        if type(x) == int and x > 0:
            return f(x)
        else:
            raise Exception("Argument is not an integer")
    return helper

@argument_test_natural_number
def factorial(n):
	if n == 1:
		return 1
	else:
		return n * factorial(n-1)

print(factorial(3))
print(factorial(-1))




























