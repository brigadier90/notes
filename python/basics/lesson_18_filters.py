grades = ['A', 'C', 'F', 'F' , 'B', 'A', 'C', 'A', 'A', 'F']



#suppose we want to filter out the Fs

def remove_fails(grade):
	return grade != 'F'


passing_grades = []

#METHOD 1: LIST COMPREHENSION
#passing_grades = [g for g in grades if (remove_fails(g))]

#method 2: filters
passing_grades = filter(remove_fails, grades) #in py3 have to typecase to list

print(passing_grades)