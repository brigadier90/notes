from modeltranslation.translator import translator, TranslationOptions
from .models import About_us

@register(About_us)
class AboutUsTranslationOptions(TranslationOptions):
    fields = ('header', 'body',)

translator.register(About_us, AboutUsTranslationOptions)