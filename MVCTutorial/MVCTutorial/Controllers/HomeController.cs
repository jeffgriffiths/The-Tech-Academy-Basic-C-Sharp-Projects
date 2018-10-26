using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // ----Sending to new view based on Random number comparison----
            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //ViewBag.RandomNumber = num;

            //if (num > 2000)
            //{
            //    return View("About");
            //}

            // ----Returning text to display----
            //return Content("Hello");

            // ----Similar to view, but doesn't change URL or hit controller method----
            //return RedirectToAction("Contact");
            //return View("") == View("Index")

            // ----Logging----
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\jeffg_000\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\MVCTutorial\Log\log.txt", text);

            // -----You can add stuff like lists -------
            //List<string> names = new List<string>
            //{
            //    "Jeff",
            //    "Leanne",
            //    "Camryn",
            //    "Kai",
            //    "Kellen"
            //};
            //return View(names);

            User user = new User();
            user.Id = 1;
            user.FirstName = "Jeff";
            user.LastName = "Griffiths";
            user.Age = 32;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            // throw new Exception("Invalid page");

            return View();
        }

        //public ActionResult Contact(int id=0)
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            //ViewBag.Message = id;

            return View();
        }
    }
}