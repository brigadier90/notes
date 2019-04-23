from django.conf.urls import url, include
from . import views

app_name = 'accounts' #namespace these urls so that in case we have details path in another app we can distinguish

urlpatterns = [
	url(r'^signup/$', views.signup_view, name='signup'),
	url(r'^login/$', views.login_view, name='login'),
	url(r'^logout/$', views.logout_view, name='logout'),
]