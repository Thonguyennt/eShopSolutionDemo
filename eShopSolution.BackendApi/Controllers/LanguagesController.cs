using System.Threading.Tasks;
using eShopSolution.Application.System.Languages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguageService _languageService;

        public LanguagesController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var product = await _languageService.GetAll();
            return Ok(product);
        }
    }
}
