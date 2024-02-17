using TranslationsAPI.Interfaces;
using TranslationsAPI.Models;
using TranslationsAPI.StaticClasses;

namespace TranslationsAPI.Implementations
{
    public class TranslationService : ITranslationService
    {
        public string getTranslatedPhrase(PhraseToTranslateByLanguage phraseToTranslate)
        {
            TranslationsInMemory translationsInMemory = TranslationsInMemory.Instance;
            var dictionary = translationsInMemory.TranslatedPhrases;
            int index = Array.BinarySearch(dictionary, new TranslatedPhraseByLanguage()
            {   LanguageCode = phraseToTranslate.LanguageCode, ProductCode = phraseToTranslate.ProductCode,
                PhraseToTranslate = phraseToTranslate.PhraseToTranslate
            });

            if (index >= 0)
                return dictionary[index].TranslatedPhrase;
            else
                return string.Empty;
        }
    }
}
