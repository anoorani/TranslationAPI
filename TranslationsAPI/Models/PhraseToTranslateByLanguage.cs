using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TranslationsAPI.Models
{
    public class PhraseToTranslateByLanguage
    {
        public required string ProductCode {  get; set; }
        public required string LanguageCode { get; set; }
        public required string PhraseToTranslate { get; set; }
    }
}
