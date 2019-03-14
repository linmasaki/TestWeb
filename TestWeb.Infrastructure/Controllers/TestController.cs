using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestWeb.Infrastructure.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Fire()
        {
            return Content("Hello!!!!!");
        }
    }
}