from django.conf.urls import url, include
from . import views

app_name = 'about' #namespace these urls so that in case we have details path in another app we can distinguish

urlpatterns = [
	url(r'^about-us/$', views.about_us_page, name='about_us'),
]