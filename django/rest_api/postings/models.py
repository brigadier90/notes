# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models

# Create your models here.
from django.conf import settings
from django.urls import reverse

from rest_framework.reverse import reverse as api_reverse

# django hosts --> subdomain for reverse

class BlogPost(models.Model):
    # pk aka id --> numbers
	user        = models.ForeignKey(settings.AUTH_USER_MODEL, on_delete=models.CASCADE) 
	title       = models.CharField(max_length=120, null=True, blank=True)
	content     = models.TextField(max_length=120, null=True, blank=True)
	timestamp   = models.DateTimeField(auto_now_add=True)

	def __str__(self):
		return str(self.user.username)
