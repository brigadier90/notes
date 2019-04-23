# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models
from django.contrib.auth.models import User


# Create your models here.
#DOC: for fields https://docs.djangoproject.com/en/2.0/ref/models/fields/

class Article(models.Model):
	title = models.CharField(max_length=100)
	slug = models.SlugField()
	body = models.TextField()
	date = models.DateTimeField(auto_now_add=True)
	thumb = models.ImageField(default='default.png', blank=True) #we upload default manually
	author = models.ForeignKey(User, default=None)


	def __str__(self):
		return self.title

	def snippet(self):

		if len(self.body)> 50:
			return self.body[:50] + "..."
		else: 
			return self.body
