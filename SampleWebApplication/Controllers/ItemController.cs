using Microsoft.AspNetCore.Mvc;
using SampleWebApplication.Models;

namespace SampleWebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        public NewCompanyModel Post(CompanyModel item) => new NewCompanyModel
        {
            IsValid = string.IsNullOrEmpty(item.Name) && !string.IsNullOrEmpty(item.Description)
        };
    }
}