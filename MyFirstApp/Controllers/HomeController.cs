using System.Collections.Generic;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        [Route("Home/Index")] // This is Attribute Routing Example which is present in
                              // routes.MapMvcAttributeRoutes() Method in RouteConfig.cs
        [Route("")] // This is for By default Comes.
        public ActionResult Index()
        {
            ViewBag.Message = "Index Action method of Home Page";
            return View();
        }
        [Route("home/product")]
        public ActionResult Product()
        {
            return View("OurCompanyProduct");
        }
        [Route("home/contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Welcome to Contact Us";
            return View();
        }
        [Route("home/userprofile")]
        public ActionResult Userprofile()
        {
            ViewBag.Message = "Welcome to User profile";
            return View();
        }
        
        public ActionResult GetEmpName(int EmpId)
        {
            // Example of Content Result
            var employees = new[]
            {
                new{EmpId = 1, EmpName = "Amardeep", salary = 30000 },
                new { EmpId = 2, EmpName = "Mukesh", salary = 25000 },
                new { EmpId = 3, EmpName = "Rakesh", salary = 45000 }
            };
            string matchEmpName = null;
            foreach(var item in employees)
            {
                if(item.EmpId == EmpId)
                {
                    matchEmpName = item.EmpName;
                }
            }
            //return new ContentResult() { Content = matchEmpName, ContentType = "text/plain" };
            return Content(matchEmpName, "text/plain");
        }
        [Route("home/getpayslip/{EmpId}")]
        public ActionResult GetPaySlip(int EmpId)
        {
           
                // Example of File Result
                string fileName = "~/PaySlip" + EmpId + ".pdf";
                return File(fileName, "application/pdf");
            
        }
        [Route("home/empfacebookpage")]
        public ActionResult EmpFacebookPage(int EmpId)
        {
            // Example of Redirect Result
            var employees = new[]
            {
                new{EmpId = 1, EmpName = "Amardeep", salary = 30000 },
                new { EmpId = 2, EmpName = "Mukesh", salary = 25000 },
                new { EmpId = 3, EmpName = "Rakesh", salary = 45000 }
            };
            string fbUrl = null;
            foreach(var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    fbUrl = "http://www.facebook.com/emp" + EmpId;
                }
                if (fbUrl == null)
                {
                    return Content("Invalid Employee Id");
                }
                else
                {
                    return Redirect(fbUrl);
                }
            }
            return Redirect(fbUrl);
        }
        [Route("home/studentdetails")]
        public ActionResult StudentDetails()
        {
            // This is Example of Razor Code Block also
            // Focus Razor If Statement in the view
            ViewBag.StudentId = 101;
            ViewBag.StudentName = "Amardeep";
            ViewBag.Marks = 80;
            ViewBag.NoOfSemester = 6;
            ViewBag.Subject = new List<string>() { "Maths", "Physics", "Chemistry" };
            return View();    
        }
        [Route("home/about")]
        public ActionResult About()
        {
            ViewBag.Message = "Welcome to About us.";
            return View();
        }
       
    }
}