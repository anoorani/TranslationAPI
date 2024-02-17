using TranslationsAPI.Models;

namespace TranslationsAPI.Interfaces
{
    public interface ITranslationService
    {
        string getTranslatedPhrase(PhraseToTranslateByLanguage phraseToTranslate);
    }
}
