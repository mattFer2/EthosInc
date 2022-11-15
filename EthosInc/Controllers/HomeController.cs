using EthosInc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EthosInc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductRepository repository;
        public HomeController(ILogger<HomeController> logger, IProductRepository repo)
        {
            _logger = logger;
            repository = repo;
        }

        /* Webpage Views */
        public IActionResult Index()
        {
            return View();
        }

        [Route("Policy")] /* [Route()] hides the "/home/" from the URL (https://stackoverflow.com/a/22828147) */
        public IActionResult Policy()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("FAQ")]
        public IActionResult FAQ()
        {
            return View();
        }

        [Route("Shop")]
        public ViewResult Shop() => View(repository.Products);

        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("Cart")]
        public IActionResult Cart()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}