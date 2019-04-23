from django.shortcuts import render
from django.http import HttpResponse#[before(serializers):], JsonResponse[endbefore]we do not need this anymore
from django.views.decorators.csrf import csrf_exempt
from rest_framework.renderers import JSONRenderer
from rest_framework.parsers import JSONParser

#added in [before(requests_and_responses)]
from rest_framework.decorators import api_view
from rest_framework import status
from rest_framework.response import Response
from snippets.models import Snippet
from snippets.serializers import SnippetSerializer

# Create your views here.

#before(serializers): 		Writing regular Django views using our Serializer
#							It's worth noting that there are a couple of edge cases we're not dealing with properly 
#							at the moment. If we send malformed json, or if a request is made with a method that the 
#							view doesn't handle, then we'll end up with a 500 "server error" response. Still, 
#							this'll do for now.

#before(requests_an_responses):	

#before(serializers)				
# @csrf_exempt #because we want to be able to POST to this view from clients that won't have a CSRF token
# def snippet_list(request):
# 	"""
# 	List all code snippets, or create a new snippet.
# 	"""
# 	if request.method == 'GET':
# 		snippets = Snippet.objects.all()
# 		serializer = SnippetSerializer(snippets, many=True)
# 		return JsonResponse(serializer.data, safe=False)

# 	elif request.method == 'POST':
# 		data = JSONParser().parse(request)
# 		serializer = SnippetSerializer(data=data)
# 		if serializer.is_valid():
# 			serializer.save()
# 			return JsonResponse(serializer.data, status=201)
# 		return JsonResponse(serializer.errors, status=400)
#[endbefore]

#wrapper/decorator for working with function based views.
# wrappers also provide behaviour such as returning 405 Method Not Allowed responses when appropriate, 
# and handling any ParseError exception that occurs when accessing request.data with malformed input.
@api_view(['GET', 'POST']) 
def snippet_list(request, format=None):
	"""
	List all code snippets, or create a new snippet.
	"""
	if request.method == 'GET':
		snippets = Snippet.objects.all()
		serializer = SnippetSerializer(snippets, many=True)
		return Response(serializer.data) 	#not using JSON response anymore. #this Response object takes unrendered content and uses content 
											#negotiation to determine the correct content type to return to the client.

	elif request.method == 'POST':
		#REST framework introduces a Request object that extends the regular HttpRequest, 
		#and provides more flexible request parsing. request.data attribute, which is similar to request.
		#POST, but more useful for working with Web APIs.
		#i.e:
		#request.POST  # Only handles form data.  Only works for 'POST' method.
		#request.data  # Handles arbitrary data.  Works for 'POST', 'PUT' and 'PATCH' methods.
		serializer = SnippetSerializer(data=request.data)
		if serializer.is_valid():
			serializer.save()
			return Response(serializer.data, status=status.HTTP_201_CREATED) 
		return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST) #REST framework provides more explicit identifiers for each status code, such as HTTP_400_BAD_REQUEST

#We'll also need a view which corresponds to an individual snippet, and can be used to 
#retrieve, update or delete the snippet.
#before(serializers)
# @csrf_exempt
# def snippet_detail(request, pk):
# 	"""
# 	Retrieve, update or delete a code snippet.
# 	"""
# 	try:
# 		snippet = Snippet.objects.get(pk=pk)
# 	except Snippet.DoesNotExist:
# 		return HttpResponse(status=404)

# 	if request.method == 'GET':
# 		serializer = SnippetSerializer(snippet)
# 		return JsonResponse(serializer.data)

# 	elif request.method == 'PUT':
# 		data = JSONParser().parse(request)
# 		serializer = SnippetSerializer(snippet, data=data)
# 		if serializer.is_valid():
# 			serializer.save()
# 			return JsonResponse(serializer.data)
# 		return JsonResponse(serializer.errors, status=400)

# 	elif request.method == 'DELETE':
# 		snippet.delete()
# 		return HttpResponse(status=204)
#[endbefore]

# To take advantage of the fact that our responses are no longer hardwired to a single content 
# type let's add support for format suffixes to our API endpoints. Using format suffixes gives us 
# URLs that explicitly refer to a given format, and means our API will be able to handle URLs such 
# as http://example.com/api/items/4.json.

# Start by adding a format keyword argument to both of the views, like so. 
#GO TO URLS PAGE to append a set of format_suffix_patterns in addition to the existing URLs.
@api_view(['GET', 'PUT', 'DELETE'])
def snippet_detail(request, pk, format=None):
	"""
	Retrieve, update or delete a code snippet.
	"""
	try:
		snippet = Snippet.objects.get(pk=pk)
	except Snippet.DoesNotExist:
		return Response(status=status.HTTP_404_NOT_FOUND)

	if request.method == 'GET':
		serializer = SnippetSerializer(snippet)
		#Notice that we're no longer explicitly tying our requests or responses to a given 
		#content type. request.data can handle incoming json requests, but it can also handle other formats
		return Response(serializer.data)

	elif request.method == 'PUT':
		serializer = SnippetSerializer(snippet, data=request.data)
		if serializer.is_valid():
			serializer.save()
			return Response(serializer.data)
		return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

	elif request.method == 'DELETE':
		snippet.delete()
		return Response(status=status.HTTP_204_NO_CONTENT)











