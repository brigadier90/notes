from rest_framework import serializers
from snippets.models import Snippet, LANGUAGE_CHOICES, STYLE_CHOICES


# we'd like to use a hyperlinked style between entities. In order to do so, we'll modify our serializers to extend 
# HyperlinkedModelSerializer instead of the existing ModelSerializer
class SnippetSerializer(serializers.HyperlinkedModelSerializer):
	#this class does not include id by default
	owner = serializers.ReadOnlyField(source='owner.username')
	#Notice that we've also added a new 'highlight' field. This field is of the same type as the url field, except 
	#that it points to the 'snippet-highlight' url pattern, instead of the 'snippet-detail' url pattern.
	#Because we've included format suffixed URLs such as '.json', we also need to indicate on the highlight 
	#field that any format suffixed hyperlinks it returns should use the '.html' suffix.
	highlight = serializers.HyperlinkedIdentityField(view_name='snippet-highlight', format='html')

	class Meta:
		model = Snippet
		#It includes a url field, using HyperlinkedIdentityField
		#Relationships use HyperlinkedRelatedField, instead of PrimaryKeyRelatedField.
		fields = ('url', 'id', 'highlight', 'owner',
                  'title', 'code', 'linenos', 'language', 'style')



from django.contrib.auth.models import User

#n_0: 	adding authentication

class UserSerializer(serializers.HyperlinkedModelSerializer):
	#Relationships use HyperlinkedRelatedField, instead of PrimaryKeyRelatedField.
	snippets = serializers.HyperlinkedRelatedField(many=True, view_name='snippet-detail', read_only=True)

	class Meta:
		model = User
		#Because 'snippets' is a reverse relationship on the User model, it will not be included 
		#by default when using the ModelSerializer class, so we needed to add an explicit field for it.
		fields = ('id', 'username', 'snippets')	

