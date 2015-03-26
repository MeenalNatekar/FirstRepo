using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication4.Models;

namespace MvcApplication4.Controllers
{
    public class EmployeeController : Controller
    {       
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Employee()
        {
            Employee em = new Employee();
            em.FirstName = "Meenal";
            em.LastName = "Natekar";
            em.Department = "Software Development";
            em.Designation = "Senior Software Engineer";
            return View(em);
        }
        [HttpPost]
        public ActionResult Employee(Employee objEmp)
        {

            return View();
        }
    }
}
