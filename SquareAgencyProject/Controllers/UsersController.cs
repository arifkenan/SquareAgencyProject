using Microsoft.AspNetCore.Mvc;

namespace AccountApplication.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
