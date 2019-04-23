from django.db import models

from django.db import models

class Person(models.Model):
	#id = models.AutoField(primary_key=True)
	first_name = models.CharField(max_length=30)
	last_name = models.CharField(max_length=30)

# Above model creates db like:
# CREATE TABLE myapp_person ( myapp_person, is automatically derived from some model metadata but can be overridden
#     "id" serial NOT NULL PRIMARY KEY, --> created automatically, can be overridden
#     "first_name" varchar(30) NOT NULL,
#     "last_name" varchar(30) NOT NULL
# ); <--this is postgresql by default

class Musician(models.Model):
	#Each field type, except for ForeignKey, ManyToManyField and OneToOneField, takes an optional 
	#first positional argument – a verbose name. If the verbose name isn’t given, Django will 
	#automatically create it using the field’s attribute name, converting underscores to spaces.
	#DO NOT CAPITALIZE VERBOSE NAME - NOT ADVISES
	first_name = models.CharField("person's first name", max_length=50)
	last_name = models.CharField(max_length=50)
	instrument = models.CharField(max_length=100)

class Album(models.Model):
	#ForeignKey, ManyToManyField and OneToOneField require the first argument to be a model class, 
	#so use the verbose_name keyword argument:
	artist = models.ForeignKey(Musician, on_delete=models.CASCADE)
	name = models.CharField(max_length=100)
	release_date = models.DateField()
	num_stars = models.IntegerField()