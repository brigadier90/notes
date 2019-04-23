def cough_dec(func):

	def func_wrapper():
		print("*cough*")
		func()
		print("*cough*")

	return func_wrapper



@cough_dec #decorators like the one defined above allows you to do somethine before a function and after it
def question():
	print("can you give me a discount on that?")

#can be used multiple times
@cough_dec
def answer():
	print("it's only 50p you cheapskate")

question()
answer()

#MUST RESEARCH MORE ON THIS TOPIC, ALSO *ARGS AND *KWARGS