using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.hums = repo.Humanitarians.ToList();
            ViewBag.prod = repo.Products.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult RequestSupplies(Request request)
        {
            repo.AddRequest(request);

            ViewBag.text = "Submitted Request";
            return View("Confirmation");
        }

        public IActionResult ViewRequests()
        {
            ViewBag.hums = repo.Humanitarians.ToList();
            ViewBag.prod = repo.Products.ToList();
            var requests = repo.Requests.ToList();

            return View(requests);
        }

        [HttpGet]
        public IActionResult RequestDetails(int id)
        {
            ViewBag.prodList = new List<Product>();
            var request = repo.Requests.FirstOrDefault(x => x.RequestId == id);
            ViewBag.dons = repo.Donations.Where(x => x.HumanitarianId == id).ToList();
            foreach (Donation donation in ViewBag.dons)
            {
                var production = repo.Productions.FirstOrDefault(x => x.ProductionId == donation.ProductionId);
                var product = repo.Products.FirstOrDefault(x => x.ProductId == production.ProductId);
                ViewBag.prodList.Add(product);
            }

            ViewBag.hum = repo.Humanitarians.FirstOrDefault(x => x.OrgId == request.HumanitarianId);
            ViewBag.prod = repo.Products.FirstOrDefault(x => x.ProductId == request.ProductId);
            return View(request);
        }

        public IActionResult FulfillRequest()
        {
            //Currently not available in Alpha testing
            ViewBag.text = "Started Request Fulfillment";
            return View("Confirmation");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
