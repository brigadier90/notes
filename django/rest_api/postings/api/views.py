# generic views (from rest_framework)
#http://www.django-rest-framework.org/api-guide/generic-views/
from django.db.models import Q
from rest_framework import generics, mixins
from postings.models import BlogPost

from.serializers import BlogPostSerializer

#add createModeMixin to allow posting new objects
class BlogPostAPIView(mixins.CreateModelMixin, generics.ListAPIView):
	lookup_field = 'pk' #pk by default, could be slug or id

	serializer_class = BlogPostSerializer

	query_set = BlogPost.objects.all()

	def get_queryset(self): #we have to overide this
		qs = BlogPost.objects.all()
		query = self.request.GET.get("q")

		if query is not None:
			qs = qs.filter(Q(title__icontains=query)|Q(content__icontains=query)).distinct() #Q allows to do OR
		return qs

	def perform_create(self, serializer):
		serializer.save(user=self.request.user)

	def post(self, request, *args, **kwargs):
		return self.create(request, *args, **kwargs)

class BlogPostRUDView(generics.RetrieveUpdateDestroyAPIView):
	lookup_field = 'pk' #pk by default, could be slug or id

	serializer_class = BlogPostSerializer

	query_set = BlogPost.objects.all()

	def get_queryset(self): #we have to overide this
		return BlogPost.objects.all()

	#commented this out since this is what lookup_field basically does
	# def get_object():
	# 	pk = self.kwargs.get("pk")
	# 	return BlogPost.objects.get(pk=pk)


