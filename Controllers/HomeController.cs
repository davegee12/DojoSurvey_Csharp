using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]       //type of request
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(string name, string location, string language, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View("Success");
        }
        // [HttpGet("result")]
        // public ViewResult Success()
        // {
        //     return View();
        // }
    }
}
