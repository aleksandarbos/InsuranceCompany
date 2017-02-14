using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreSPA.BLL;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.Web.Controllers
{

    public class HomeController : Controller
    {
        private readonly IHomeBLL _homeBLL;

        public HomeController(IHomeBLL homeBLL)
        {
            _homeBLL = homeBLL;
        }

        // GET: Application entry point
        public IActionResult Index()
        {
            return View("index");
        }

       
    }
}