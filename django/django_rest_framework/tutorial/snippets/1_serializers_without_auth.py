from rest_framework import serializers
from snippets.models import Snippet, LANGUAGE_CHOICES, STYLE_CHOICES


#n_0: 	lot of repetition from model to serializer. in [beofre(n_0)] we had to respecify all fields
# 		can instead use serializers.ModelSerializer like form.ModelForm. 
#		Model serializers create:
#		1)An automatically determined set of fields.
#		2)Simple default implementations for the create() and update() methods.



class SnippetSerializer(serializers.ModelSerializer):#[before(n_0)]serializers.Serializer):#[endbefore]
	
	#[after(n_0)]
	class Meta:
		model = Snippet
		fields = ('id', 'title', 'code', 'linenos', 'language', 'style')
	#[endafter]


	#[before(n_0)]
	# id = serializers.IntegerField(read_only=True)
	# title = serializers.CharField(required=False, allow_blank=True, max_length=100)
	# code = serializers.CharField(style={'base_template': 'textarea.html'}) #equivalent to using widget=widgets.Textarea
	# linenos = serializers.BooleanField(required=False)
	# language = serializers.ChoiceField(choices=LANGUAGE_CHOICES, default='python')
	



	# def create(self, validated_data):
	# 	"""
	# 	Create and return a new `Snippet` instance, given the validated data.
	# 	"""
	# 	return Snippet.objects.create(**validated_data)

	# def update(self, instance, validated_data):
	# 	"""
	# 	Update and return an existing `Snippet` instance, given the validated data.
	# 	"""
	# 	instance.title = validated_data.get('title', instance.title)
	# 	instance.code = validated_data.get('code', instance.code)
	# 	instance.linenos = validated_data.get('linenos', instance.linenos)
	# 	instance.language = validated_data.get('language', instance.language)
	# 	instance.style = validated_data.get('style', instance.style)
	# 	instance.save()
	# 	return instance
	#[endbefore]



# SHELLEX
# from snippets.models import Snippet
# from snippets.serializers import SnippetSerializer
# from rest_framework.renderers import JSONRenderer
# from rest_framework.parsers import JSONParser

# create some snippet objects
# snippet = Snippet(code='foo = "bar"\n')
# snippet.save()

# snippet = Snippet(code='print "hello, world"\n')
# snippet.save()

# serilaize the instance to turn it into python native data type
# serializer = SnippetSerializer(snippet)
# serializer.data

# render data into json
# content = JSONRenderer().render(serializer.data)
# content

# Deserialization is similar. First we parse a stream into Python native datatypes...

# from django.utils.six import BytesIO

# stream = BytesIO(content)
# data = JSONParser().parse(stream)
# ...then we restore those native datatypes into a fully populated object instance.

# serializer = SnippetSerializer(data=data)
# serializer.is_valid()
# # True
# serializer.validated_data
# # OrderedDict([('title', ''), ('code', 'print "hello, world"\n'), ('linenos', False), ('language', 'python'), ('style', 'friendly')])
# serializer.save()
# # <Snippet: Snippet object>


# We can also serialize querysets instead of model instances. To do so we simply add a many=True flag to the serializer arguments.
# serializer = SnippetSerializer(Snippet.objects.all(), many=True)
# serializer.data
# ouput:			[OrderedDict([('id', 1), ('title', u''), ('code', u'foo = "bar"\n'), ('linenos', False), ('language', 'python'), ('style', 'friendly')]), 
# output contd: 	 OrderedDict([('id', 2), ('title', u''), ('code', u'print "hello, world"\n'), ('linenos', False), ('language', 'python'), ('style', 'friendly')]), OrderedDict([('id', 3), ('title', u''), ('code', u'print "hello, world"'), ('linenos', False), ('language', 'python'), ('style', 'friendly')])]




# from snippets.serializers import SnippetSerializer
# serializer = SnippetSerializer()
# print(repr(serializer))
# # SnippetSerializer():
# #    id = IntegerField(label='ID', read_only=True)
# #    title = CharField(allow_blank=True, max_length=100, required=False)
# #    code = CharField(style={'base_template': 'textarea.html'})
# #    linenos = BooleanField(required=False)
# #    language = ChoiceField(choices=[('Clipper', 'FoxPro'), ('Cucumber', 'Gherkin'), ('RobotFramework', 'RobotFramework'), ('abap', 'ABAP'), ('ada', 'Ada')...
# #    style = ChoiceField(choices=[('autumn', 'autumn'), ('borland', 'borland'), ('bw', 'bw'), ('colorful', 'colorful')...

