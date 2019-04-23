from random import shuffle


words = ['Pillow', "Phone", "Water", "Ice"]

#suppose we want to jumble up the words and assign them to another array

def jumble(word):
	anagram = list(word)
	shuffle(anagram) #this function returns none, therefore imperative to assign list(word) to anagram first
	return ''.join(anagram)

jumbled_list = []

#METHOD 1: for loop
# for w in words:
# 	jumbled_list.append(jumble(w))



#METHOD 2: List comprehension
# jumbled_list = [jumble(w) for w in words]


#METHOD 3: using map(function, list)
jumbled_list = list(map(jumble, words)) #in python 2 works without converting to list



print(jumbled_list)