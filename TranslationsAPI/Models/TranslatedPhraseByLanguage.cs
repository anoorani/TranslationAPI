using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TranslationsAPI.Models
{
    
    public class TranslatedPhraseByLanguage: IComparable<TranslatedPhraseByLanguage>
    {
        public required string ProductCode {  get; set; }
        public required string LanguageCode { get; set; }
        public required string PhraseToTranslate { get; set; }
        public string TranslatedPhrase { get; set; }

        // comparer will be used to Keep a list of sorted Phrases and then we can use binary search to traverse
        public int CompareTo(TranslatedPhraseByLanguage? other)
        {
            if (other == null) return 1;
            int compareByProductCode = ProductCode.CompareTo(other.ProductCode);
            if (compareByProductCode != 0)
                return compareByProductCode;
            else
            {
                int compareByLanguageCode = ProductCode.CompareTo(other.ProductCode);
                if (compareByLanguageCode != 0)
                    return compareByLanguageCode;
                else
                { //this is where string comparison will happen.
                  // before we compare strings, we should compare by the length of the string so we can exit faster if its not the same length
                    int compareByPhraseLength = PhraseToTranslate.Length.CompareTo(other.PhraseToTranslate.Length);
                    if (compareByPhraseLength != 0)
                        return compareByPhraseLength;
                    else
                    {
                        return PhraseToTranslate.CompareTo(other.PhraseToTranslate);
                    }
                }
            }
        }
    }
}
