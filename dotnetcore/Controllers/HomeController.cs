using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetcore.Models;
using Microsoft.Extensions.Options;
namespace dotnetcore.Controllers
{
    public class HomeController : Controller
    {
        public Content contents;
        public HomeController(IOptions<Content> options)
        {
            contents = options.Value;
        }

        public IActionResult Index()
        {
            return View(contents);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View(contents);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View(contents);
        }

        public IActionResult Privacy()
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
