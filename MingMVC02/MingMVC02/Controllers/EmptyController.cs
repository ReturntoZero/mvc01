﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MingMVC02.Controllers
{
    public class EmptyController : Controller
    {
        // GET: Empty
        public ActionResult Index()
        {
            return View();
        }
    }
}