﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenBinhMinh_Bigschool.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Create()
        {
            return View();
        }
    }
}