using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SampleWebApplication.Database;

namespace SampleWebApplication.ViewComponents
{
    public class LatestItem : ViewComponent
    {
        private readonly CompanyDbContext _dbContext;

        public LatestItem(CompanyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var latestItem = _dbContext.Items
                .OrderByDescending(x => x.Id).First();
            return View("Index", latestItem);
        }
    }
}