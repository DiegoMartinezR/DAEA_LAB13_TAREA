﻿using Domain;
using MVCAjax.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MVCAJAX.Controllers
{
    public class ControllerStudent : Controller 
    {
        private StudentService service = new StudentService();


        public ActionResult IndexRazor()
        {
            var model = (from c in service.Get()

                         select new StudentModel
                         {
                             ID = c.studentID,
                             Address = c.studentAddress,
                             Name = c.studentName
                         }).ToList();

            return View(model);
        }


        public ActionResult Index()
        {
            return View();
        }


        public JsonResult getStudent(string id)
        {
            return Json(service.Get(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult createStudent(Student std)
        {
            service.Insert(std);
            string message = "SUCCESS";
            return Json(new
            {
                Message = message,
                JsonRequestBehavior.AllowGet
            });
        }

    }
}