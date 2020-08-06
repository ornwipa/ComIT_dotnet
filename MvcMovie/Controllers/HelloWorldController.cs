using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

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
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

        // Every public method in a controller is callable as an HTTP endpoint. 
        // In the sample above, both methods return a string.

        // An HTTP endpoint is a targetable URL in the web application, such as 
        // https://localhost:5001/HelloWorld, and combines the protocol used: HTTPS, 
        // the network location of the web server (including the TCP port): localhost:5001 
        // and the target URI HelloWorld.
    }
}