using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        // public string Index()
        // {
        //     return "This is my default action...";
        // }
        public IActionResult Index()
        {
            return View(); // the method uses a view template file to render a response to the browser.
        }
        // The preceding code calls the controller's View method. 
        // It uses a view template to generate an HTML response. 
        // Controller methods (also known as action methods), such as the Index method above, 
        // generally return an IActionResult (or a class derived from ActionResult).

        // 
        // GET: /HelloWorld/Welcome/ 

        // public string Welcome()
        // {
        //     return "This is the Welcome action method...";
        // }
        // public string Welcome(string name, int numTimes = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        // }
        // public string Welcome(string name, int ID = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        // }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        // Every public method in a controller is callable as an HTTP endpoint. 
        // In the sample above, both methods return a string.

        // An HTTP endpoint is a targetable URL in the web application, such as 
        // https://localhost:5001/HelloWorld, and combines the protocol used: HTTPS, 
        // the network location of the web server (including the TCP port): localhost:5001 
        // and the target URI HelloWorld.
    }
}