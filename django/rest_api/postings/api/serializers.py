from rest_framework import serializers
from postings.models import BlogPost

#Serializers do 2 things:
# 1. convert to JSON
# 2. Validates Data

class BlogPostSerializer(serializers.ModelSerializer):

	class Meta:
		model 		= BlogPost

		fields = [
			'pk',
			'user',
			'title',
			'content',
			'timestamp',
		]

		read_only_fields = ['user'] #pk set by default

		#same idea as def clean_<fieldname> for forms (look it up)
	def validate_title(self, value):
		 qs = BlogPost.objects.filter(title__iexact=value)

		 if self.instance:
		 	qs = qs.exclude(pk=self.instance.pk)
		 if qs.exists():
		 	raise serializers.ValidationError("""This title has already been used""")
		 return value



