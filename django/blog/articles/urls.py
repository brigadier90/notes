from django.conf.urls import url, include
from . import views

app_name = 'articles' #namespace these urls so that in case we have details path in another app we can distinguish

urlpatterns = [
	url(r'^$', views.articles_list, name='list'),
	#reason this url comes before the one below is so that the literal 'create' is not mistaken for a slug.
	#Since this url comes before the one below it will have precedence
	url(r'^create/$', views.article_create, name='create'),
	url(r'^(?P<slug>[\w-]+)/$', views.article_details, name='details'),
]