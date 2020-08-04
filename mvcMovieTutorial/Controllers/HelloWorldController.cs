using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mvcMovieTutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        // public string Index()
        // {
        //     return "This is the default action...";
        // }
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        // public string Welcome(string name, int ID = 1)
        // {
        //     //return "This is the Welcome action method...";
        //     //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //     return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        // }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}