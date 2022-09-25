

using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;


namespace MvcWeb.Controllers;


public class NewController : Controller
{

    
        public IActionResult Index()
        {
            return View();
        }


        public DateTime time { get; set; }
        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Wel(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

}