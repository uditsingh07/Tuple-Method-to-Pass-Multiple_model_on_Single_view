using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;
using Tuple_Method_to_Pass_Multiple_model_on_Single_view.Models;

namespace Tuple_Method_to_Pass_Multiple_model_on_Single_view.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var employees = GetEmployees();
            var students = GetStudnets();

            var model = new Tuple<List<Employee>, List<Student>>(employees, students);
            return View(model);
        }

        private List<Employee> GetEmployees()
        {
            return new List<Employee> {
            new Employee() { Name = "Udit", Email = "udit@gmail.com" },
            new Employee() { Name = "Singh", Email = "singh@gmail.com" }
        };
        } 
        
        private List<Student> GetStudnets()
        {
            return new List<Student> {
            new Student() { Name = "John", Email = "john@gmail.com" },
            new Student() { Name = "Doe", Email = "doe@gmail.com" }
        };
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}