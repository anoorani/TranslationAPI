using TranslationsAPI.Models;

namespace TranslationsAPI.StaticClasses
{
    //Below Class Implements Singleton Design Pattern
    public sealed class TranslationsInMemory
    {        
        TranslatedPhraseByLanguage[] _translatedPhrases = new TranslatedPhraseByLanguage[1];

        private TranslationsInMemory()
        {
            //This block of code will only run only once on the 1st call for Translations
            TranslatedPhraseByLanguage phraseToTranslate = new() {  ProductCode = "in", LanguageCode = "gm", PhraseToTranslate = "Your insurance documents have been submitted", TranslatedPhrase = "Ihre Versicherungsunterlagen wurden eingereicht" };
            _translatedPhrases[0] = phraseToTranslate;
        }

        public TranslatedPhraseByLanguage[] TranslatedPhrases { get {  return _translatedPhrases; } }

        // Using laziness to make it thread safe

        private static readonly Lazy<TranslationsInMemory> lazy = new Lazy<TranslationsInMemory>(() => new TranslationsInMemory());
        public static TranslationsInMemory Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
