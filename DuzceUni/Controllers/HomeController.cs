using DuzceUni.Data;
using DuzceUni.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUni.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var values = c.Successes.ToList();
            return View(values);
        }
        public IActionResult ClickHere()
        {
            var values = c.DuzceWelcomes.ToList();
            return View(values);
        }
        public IActionResult FastAccess()
        {
            return View();
        }
        Context c = new Context();

        public IActionResult Blog()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        public IActionResult BlogDetail(int id)
        {
            var duyur = c.Blogs.Find(id);
            return View("BlogDetail", duyur);
        }
        public IActionResult Gallery()
        {
            var values = c.Gallerys.ToList();
            return View(values);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Publishing()
        {
            var values = c.Publishings.ToList();
            return View(values);
        }
    }
}
