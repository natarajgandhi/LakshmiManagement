using eManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eManager.Web.Controllers
{
    public class DepartmentController : Controller
    {
        //
        // GET: /Department/
        private IDepartmentDataSource _db;

        public DepartmentController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Details(int DepartmentId)
        {
            var department = _db.Departments.Single(x=>x.Id == DepartmentId);
            return View(department);
        }

    }
}
