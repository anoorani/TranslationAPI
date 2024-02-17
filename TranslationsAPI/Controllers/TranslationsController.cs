using Microsoft.AspNetCore.Mvc;
using TranslationsAPI.Implementations;
using TranslationsAPI.Interfaces;
using TranslationsAPI.Models;

namespace TranslationsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TranslationsController : ControllerBase
    {
        //to do use Dependency Injection 
        ITranslationService translationService = new TranslationService();    

        [HttpPost(Name = "GetTranslatedValue")]
        public string Get(PhraseToTranslateByLanguage phraseToTranslate)
        {
            return translationService.getTranslatedPhrase(phraseToTranslate);
        }
    }
}
