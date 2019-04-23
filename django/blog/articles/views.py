# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.shortcuts import render, redirect
from models import Article
from django.http import HttpResponse
from django.contrib.auth.decorators import login_required
from . import forms

# Create your views here.
def articles_list(request):
	articles = Article.objects.all()
	return render(request, 'articles/articles_list.html', {'articles':articles})

def article_details(request, slug):
	article = Article.objects.get(slug=slug)
	return render(request, 'articles/article_details.html', {'article':article})

@login_required(login_url= 'accounts:login')
def article_create(request):

	if request.method == 'POST':
		form = forms.CreateArticleForm(request.POST, request.FILES) #files come through an object seperate to POST called FILES

		if form.is_valid():
			
			#save article to DB
			articleInstance = form.save(commit=False) #so that it doesn't put it in the database without the user
			articleInstance.author = request.user
			articleInstance.save()

			return redirect('articles:list')

	else:
		form = forms.CreateArticleForm()
	
	return render(request, 'articles/article_create.html', {'form':form})