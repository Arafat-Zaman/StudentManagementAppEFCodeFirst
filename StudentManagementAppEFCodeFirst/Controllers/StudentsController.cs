using Microsoft.AspNetCore.Mvc;

namespace StudentManagementAppEFCodeFirst.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
