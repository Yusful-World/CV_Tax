using CV_Tax.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Tax.Controllers
{
    public class TaxCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult GetTax(decimal income)
        {
            var calculateTax = new TaxCalculator();
            var tax = calculateTax.CalculateTax(income);
            ViewBag.Tax = tax;
            return View("Index");
        }
    }
}
