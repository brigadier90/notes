# The order of AUTHENTICATION_BACKENDS matters (in settings.py), so if the same username and password is valid in 
# multiple backends, Django will stop processing at the first positive match.

# If a backend raises a PermissionDenied exception, authentication will immediately fail. 
# Django won’t check the backends that follow.


# class MyBackend(object):

# 	# The authenticate method takes a request argument and 
# 	# credentials as keyword arguments. Most of the time, it’ll just look like this:
# 	# authenticate() should check the credentials it gets and return a user object that 
# 	# matches those credentials if the credentials are valid. If they’re not valid, it should return None.
# 	def authenticate(self, request, username=None, password=None):
# 	# Check the username/password and return a user.
# 		pass



# The Django admin is tightly coupled to the Django User object. The best way to deal with 
# this is to create a Django User object for each user that exists for your backend (e.g., 
# in your LDAP directory, your external SQL database, etc.) You can either write a script 
# to do this in advance, or your authenticate method can do it the first time a user logs in.

#example:
# Here’s an example backend that authenticates against a username and password variable defined 
# in your settings.py file and creates a Django User object the first time a user authenticates:

from django.conf import settings
from django.contrib.auth.hashers import check_password
from django.contrib.auth.models import User

class SettingsBackend(object):
    """
    Authenticate against the settings ADMIN_LOGIN and ADMIN_PASSWORD.

    Use the login name and a hash of the password. For example:

    ADMIN_LOGIN = 'admin'
    ADMIN_PASSWORD = 'pbkdf2_sha256$30000$Vo0VlMnkR4Bk$qEvtdyZRWTcOsCnI/oQ7fVOu1XAURIZYoOZ3iq8Dr4M='
    """

	def authenticate(self, request, username=None, password=None):
		login_valid = (settings.ADMIN_LOGIN == username)
		pwd_valid = check_password(password, settings.ADMIN_PASSWORD)
		if login_valid and pwd_valid:
			try:
				user = User.objects.get(username=username)
			except User.DoesNotExist:
				# Create a new user. There's no need to set a password
				# because only the password from settings.py is checked.
				user = User(username=username)
				user.is_staff = True
				user.is_superuser = True
				user.save()
			return user
		return None

	def get_user(self, user_id):
		try:
			return User.objects.get(pk=user_id)
		except User.DoesNotExist:
			return None




