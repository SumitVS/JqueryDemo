using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JqueryDemo.Models;


using System.Web.Script.Serialization;

namespace JqueryDemo.Controllers
{
    public class JSONDemoController : Controller
    {
        // GET: JSONDemo
        public ActionResult JSONObjectAndJSONArray()
        {
            return View();
        }

        public ActionResult JSONstringify()
        {
            return View();
        }
        public ActionResult DotNetToJson()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { FirstName="Sumit",LastName="Shitole",Gender="Male",Salary=46000 });
            employees.Add(new Employee { FirstName = "Varsha", LastName = "Shitole", Gender = "Female", Salary = 48000 });

            //convert Dot net object to Json Object

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            ViewBag.JsonString=javaScriptSerializer.Serialize(employees);
            List<Employee> employeesNew = new List<Employee>();
            employeesNew=javaScriptSerializer.Deserialize(ViewBag.JsonString, typeof(List<Employee>));
            return View(employeesNew);
        }

    }
}