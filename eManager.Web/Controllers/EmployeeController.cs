using eManager.Domain;
using eManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eManager.Web.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private IDepartmentDataSource _db;

        public EmployeeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Create(int DepartmentId)
        {
            var model = new EmployeeViewModel();
            model.DepartmentId = DepartmentId;
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeViewModel model)
        {
            if(ModelState.IsValid)
            {
                var department = _db.Departments.Single(d => d.Id == model.DepartmentId);
                Employee employee = new Employee();
                employee.Name = model.Name;
                employee.HireDate = model.HireDate;
                department.Employees.Add(employee);
                _db.Save();
                return RedirectToAction("Details","Department",new {DepartmentId = model.DepartmentId});
            }

            return View();
        }
    }
}
