using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReliefProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ReliefProject.Controllers
{
    public class HomeController : Controller
    {
        private IReliefRepository repo { get; set; }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IReliefRepository temp)
        {
            _logger = logger;
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RequestSupplies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RequestSupplies(SupplyRequest sr)
        {
            ViewBag.text = "Submitted Request";
            return View("Confirmation");
        }

        public IActionResult ViewRequests()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FulfillRequest()
        {
            ViewBag.text = "Initiated Request Fulfillment";

            return View("Confirmation");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
