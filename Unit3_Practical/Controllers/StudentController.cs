using Microsoft.AspNetCore.Mvc;
using Unit3_Practical.Models;

namespace Unit3_Practical.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            // Create a sample Student object
            var student = new Student
            {
                Id = 1,
                Name = "Aayush Neupane",
                Age = 21,
                Course = "BIT"
            };

            // Pass model to the view
            return View(student);
        }
        public IActionResult Details(int id)
        {
            var student = new Student
            {
                Id = id,
                Name = "Rajendra Manandhar ",
                Age = 23,
                Course = "BIT"
            };

            return View(student);
        }
    }
}
