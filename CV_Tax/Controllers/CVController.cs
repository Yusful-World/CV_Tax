using CV_Tax.Data;
using CV_Tax.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Tax.Controllers
{
    public class CVController : Controller 
    {
        public IActionResult Index()
        {
            var cv = CVData.GetCV();
            return View(cv);
        }
    }
}
