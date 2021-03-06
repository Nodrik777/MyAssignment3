﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }

         //GET :/Teacher/List
        public ActionResult List()

        {
            TeacherDataController controller = new TeacherDataController();
            IEnumerable<Teacher> Teachers = controller.ListTeachers();
            return View();  
        }

        //GET :/Teacher/Show/{id}


        public ActionResult Show(int id, int salary)

        {

            TeacherDataController controller = new TeacherDataController;
            Teacher NewTeacher = controller.FindTeacher(id);
            

            return View(NewTeacher);
        }

     }
}