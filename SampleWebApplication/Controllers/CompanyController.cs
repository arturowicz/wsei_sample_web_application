using Microsoft.AspNetCore.Mvc;
using SampleWebApplication.Models;

namespace SampleWebApplication.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}