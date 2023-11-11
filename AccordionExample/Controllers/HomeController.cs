using AccordionExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccordionExample.Controllers
{

    public class HomeController : Controller
    {
        //jayaEntities db = new jayaEntities();
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult EmployeeForm()
        {
            return View();
        }

        // Action to display the Salary form
        public ActionResult SalaryForm()
        {
            return View();
        }

        // Action to handle form submissions
        [HttpPost]
        public ActionResult SubmitForms(Emp employee, Salary salary)
        {
            if (ModelState.IsValid)
            {
                // Save data to the backend here (e.g., using Entity Framework)

                // Assuming you have a DbContext named YourDbContext
                using (jayaEntities  db = new jayaEntities())
                {
                    // Add employee and salary to the context
                    db.Emps.Add(employee);
                    db.Salaries.Add(salary);

                    // Save changes to the database
                    db.SaveChanges();
                }

                ViewBag.Message = "Data saved successfully!";
            }
            else
            {
                ViewBag.Message = "Form validation failed. Please check your inputs.";
            }

            return View("EmployeeSalaryForms");
        }
    }
}
