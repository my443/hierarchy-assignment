using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HierarchyAssignmentWebApp.Controllers
{
    public class MVCHelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // GET: /HelloWorld/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}
        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult WelcomeWithData(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        public string Welcome1(string name, int numTimes = 1) {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        public string Welcome2(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {ID}");
        }
    }
}
