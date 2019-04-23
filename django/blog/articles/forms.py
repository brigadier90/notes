from django import forms
from . import models

class CreateArticleForm(forms.ModelForm):
	#here we define which fields we want to add to the form and which model we want to take those fields from
	class Meta: 
		model = models.Article
		fields = ['title', 'body', 'slug', 'thumb']
