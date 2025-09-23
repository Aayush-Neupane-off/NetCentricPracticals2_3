using Microsoft.AspNetCore.Mvc;

namespace Unit3_Practical.Controllers
{
    public class HelloController : Controller
    {
        // GET: /Hello/Welcome
        public IActionResult Welcome()
        {
            return Content("Welcome to ASP.NET Core! This is a response to your HTTP GET request.");
        }

        // GET: /Hello/Greet
        public IActionResult Greet(string name)
        {
            return Content($"Hello, {name}! This response is dynamically generated.");
        }
    }
}
