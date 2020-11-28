using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SampleWebApplication.Database;
using SampleWebApplication.Entities;
using SampleWebApplication.Models;

namespace SampleWebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        private readonly CompanyDbContext _dbContext;
        
        public CompanyController(CompanyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IEnumerable<CompanyEntity> Add(CompanyModel company)
        {
            var entity = new CompanyEntity
            {
                Name = company.Name,
                Description = company.Description,
                IsVisible = company.IsVisible
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();
            
            return _dbContext.Items.ToList();
        }
    }
}