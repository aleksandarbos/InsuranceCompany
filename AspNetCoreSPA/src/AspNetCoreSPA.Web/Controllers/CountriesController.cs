using AspNetCoreSPA.BLL;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreSPA.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/country")]
    public class CountriesController : Controller
    {
        private readonly ICountryBLL _countryBLL;
        private readonly IContinentBLL _continentBLL;

        public CountriesController(ICountryBLL countryBLL, IContinentBLL continentBLL)
        {
            _countryBLL = countryBLL;
            _continentBLL = continentBLL;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [Route("getAll"), HttpGet]
        public IActionResult GetAll()
        {
            var x = _continentBLL.GetAll(); // for demo only
            return Json(_countryBLL.GetAll());
        }
    }
}
