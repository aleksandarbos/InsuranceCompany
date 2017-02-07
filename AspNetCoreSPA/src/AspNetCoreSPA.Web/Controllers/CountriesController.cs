using AspNetCoreSPA.BLL;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreSPA.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/country")]
    public class CountriesController : Controller
    {
        private readonly ICountryBLL _countryBLL;

        public CountriesController(ICountryBLL countryBLL)
        {
            _countryBLL = countryBLL;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [Route("getAll"), HttpGet]
        public IActionResult GetAll()
        {
            return Json(_countryBLL.GetAll());
        }
    }
}
