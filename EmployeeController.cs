﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CURDOperationUsingAjax.Models;

namespace CURDOperationUsingAjax.Controllers
{
    public class EmployeeController : Controller
    {

        EmployeeDBHandler employeeDBHandler = new EmployeeDBHandler();
        //
        // GET: /Employee/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            return Json(employeeDBHandler.ListAll(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Add(Employee emp)
        {
            return Json(employeeDBHandler.Add(emp), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetbyID(int ID)
        {
            var Employee = employeeDBHandler.ListAll().Find(x => x.EmployeeID.Equals(ID));
            return Json(Employee, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update(Employee emp)
        {
            return Json(employeeDBHandler.Update(emp), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int ID)
        {
            return Json(employeeDBHandler.Delete(ID), JsonRequestBehavior.AllowGet);
        }


    }
}
