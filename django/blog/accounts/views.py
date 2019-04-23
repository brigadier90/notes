# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.shortcuts import render, redirect
from django.contrib.auth.forms import UserCreationForm, AuthenticationForm
from django.contrib.auth import login, logout

# Create your views here.

def signup_view(request):

	if request.method == 'POST':

		form = UserCreationForm(request.POST)

		if form.is_valid():
			user = form.save()
			login(request, user)


			return redirect('articles:list')
	else:
		form = UserCreationForm()
	
	return render(request, 'accounts/signup.html', {'form':form})

def login_view(request):

	if request.method == 'POST':
		form = AuthenticationForm(data=request.POST) #because this is not natirally first parameter of this obejct

		if form.is_valid():
			#log in the user
			user = form.get_user()
			login(request, user)

			#then recirect

			#check if next is set
			if 'next' in request.POST:
				return redirect(request.POST.get('next'))
			else:
				return redirect('articles:list')

	else:
		form = AuthenticationForm()
	
	return render(request, 'accounts/login.html', {'form':form})

def logout_view(request):
	if request.method == 'POST':
		logout(request)

	return redirect('articles:list')
