from rest_framework import serializers
from snippets.models import Snippet, LANGUAGE_CHOICES, STYLE_CHOICES



class SnippetSerializer(serializers.ModelSerializer):#[before(n_0)]serializers.Serializer):#[endbefore]
	
	owner = serializers.ReadOnlyField(source='owner.username')

	class Meta:
		model = Snippet
		fields = ('id', 'title', 'code', 'linenos', 'language', 'style', 'owner')




from django.contrib.auth.models import User

#n_0: 	adding authentication

class UserSerializer(serializers.ModelSerializer):
	snippets = serializers.PrimaryKeyRelatedField(many=True, queryset=Snippet.objects.all())

	class Meta:
		model = User
		#Because 'snippets' is a reverse relationship on the User model, it will not be included 
		#by default when using the ModelSerializer class, so we needed to add an explicit field for it.
		fields = ('id', 'username', 'snippets')	

