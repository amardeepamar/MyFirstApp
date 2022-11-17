using System.Collections.Generic;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View("OurCompanyProduct");
        }
        public ActionResult Contact()
        {
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

        public ActionResult GetPaySlip(int EmpId)
        {
            // Example of File Result
            string fileName = "~/PaySlip" + EmpId + ".pdf";
            return File(fileName, "application/pdf");
        }

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
    }
}