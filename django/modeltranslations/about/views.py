from django.shortcuts import render
from .models import About_us

# Create your views here.

def about_us_page(request):
	data = About_us.objects.first()
	return render(request, 'about/about_us_page.html', {'data':data})
