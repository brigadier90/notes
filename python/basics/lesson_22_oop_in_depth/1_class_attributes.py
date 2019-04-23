class Employee:
   'Common base class for all employees'
   empCount = 0

   def __init__(self, name, salary):
      self.name = name
      self.salary = salary
      Employee.empCount += 1
   
   def displayCount(self):
      print "Total Employee %d" % Employee.empCount

   def displayEmployee(self):
      print "Name : ", self.name,  ", Salary: ", self.salary


#build in class attributes

emp1 = Employee("Hassan", 100000)

#can add vars
emp1.age = 44

#can get attributes using following functions

# print(getattr(emp1, 'name')) #to access the attribute of object.
# print(getattr(emp1, 'age')) #to access the attribute of object.
# print(hasattr(emp1, 'age'))
# setattr(emp1, 'sex', 'male') #to set an attribute. If attribute does not exist, then it would be created.
# print(emp1.sex)
# delattr(emp1, 'age')    # Delete attribute 'age'

# __dict__ - Dictionary containing the class's namespace.

# __doc__ - Class documentation string or none, if undefined.

# __name__ - Class name.

# __module__ - Module name in which the class is defined. This attribute is "__main__" in interactive mode.

# __bases__ - A possibly empty tuple containing the base classes, in the order of their occurrence in the base class list.

print "Employee.__doc__:", Employee.__doc__
print "Employee.__name__:", Employee.__name__
print "Employee.__module__:", Employee.__module__
print "Employee.__bases__:", Employee.__bases__
print "Employee.__dict__:", Employee.__dict__













