using CV_Tax.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Tax.Controllers
{
    public class CVController : Controller 
    {
        public IActionResult Index()
        {
            var cv = new CV();
            return View(cv);
        }
    }
}
