using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shippingrequest.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace shippingrequest.Controllers
{
    public class HomeController : Controller
    {

        //private YourContext _context;//this wil be the db connection later
        //public HomeController(YourContext context)
        //{
          //_context = context;
        //}
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            System.Console.WriteLine("**********Hitting the Index Route**********");
            ViewData["Title"] = "Home Page";
            ViewData["Message"] = "This is where user will authenticate.";
            return View();
        }
        [HttpGet]
        [Route("/Form")]
        public IActionResult Form()
        {
            System.Console.WriteLine("**********Hiting the form route**********");
            //if (HttpContext.Session.GetInt32("user_id") == null)//if user tried to hit the route through url without login
            //{
                //return RedirectToAction("Index", "User");//no login go back to the root index
            //}
            ViewData["Title"] = "Shipping Request Form";
            ViewData["Message"] = "Please fill form completely";
            var formModel = new ViewModel();//this may need to be replace with a query later
            formModel.deptList = new List<string> {"AdminDawgs", "OpsNerds", "OAT-cuzns", "10T-anker", "MiXrs", "The-Others"};
            formModel.countryList = new List<string> {"Agartha", "Asgard", "Atlantis", "El Dorado", "Diyu", "Irkalla", "Mictlan", "Nibiru", "Norumbega", "Valhalla", "Zion"};
            return View(formModel);
        }
        //public IActionResult PostForm()
        //{
            //if (ModelState.IsValid)
            //{
                // do something
                //return RedirectToPage("VerifyInfo"));
            //}
            //else
            //{
                //return Page();
            //}
        //}
        [HttpGet]
        [Route("/VerifyInfo")]
        public IActionResult VerifyInfo()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
