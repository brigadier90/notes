###########################################
# Using generic class-based views
###########################################

from snippets.models import Snippet
from snippets.serializers import SnippetSerializer
from rest_framework import generics
from snippets.serializers import UserSerializer
from django.contrib.auth.models import User
from rest_framework import permissions
from snippets.permissions import IsOwnerOrReadOnly
from rest_framework.decorators import api_view
from rest_framework.response import Response
from rest_framework.reverse import reverse


class SnippetList(generics.ListCreateAPIView):
	queryset = Snippet.objects.all()
	serializer_class = SnippetSerializer
	permission_classes = (permissions.IsAuthenticatedOrReadOnly,)

	#no way of associating the user that created the snippet, with the snippet instance. The user 
	#isn't sent as part of the serialized representation, but is instead a property of the incoming 
	#request. overriding a .perform_create() method on our snippet views, that allows us to modify 
	#how the instance save is managed, and handle any information that is implicit in the incoming 
	#request or requested URL.
	def perform_create(self, serializer):
		serializer.save(owner=self.request.user)


class SnippetDetail(generics.RetrieveUpdateDestroyAPIView):
	queryset = Snippet.objects.all()
	serializer_class = SnippetSerializer
	permission_classes = (permissions.IsAuthenticatedOrReadOnly, IsOwnerOrReadOnly)


class UserList(generics.ListAPIView):
	queryset = User.objects.all()
	serializer_class = UserSerializer


class UserDetail(generics.RetrieveAPIView):
	queryset = User.objects.all()
	serializer_class = UserSerializer


@api_view(['GET'])
def api_root(request, format=None):
	return Response({
		'users': reverse('user-list', request=request, format=format),
		'snippets': reverse('snippet-list', request=request, format=format)
	})


# Creating an endpoint for the highlighted snippets
# Unlike all our other API endpoints, we don't want to use JSON, but instead just present an 
# HTML representation
# there's no existing concrete generic view that we can use. We're not returning an 
# object instance, but instead a property of an object instance.


# There are two styles of HTML renderer provided by REST framework, one for dealing with HTML 
# rendered using templates, the other for dealing with pre-rendered HTML. The second renderer 
# is the one we'd like to use for this endpoint.
from rest_framework import renderers
from rest_framework.response import Response

# Instead of using a concrete generic view, we'll use the base class for representing instances, 
# and create our own .get() method. In your snippets/views.py add:
class SnippetHighlight(generics.GenericAPIView):
	queryset = Snippet.objects.all()
	renderer_classes = (renderers.StaticHTMLRenderer,)

	def get(self, request, *args, **kwargs):
		snippet = self.get_object()
		return Response(snippet.highlighted)


















