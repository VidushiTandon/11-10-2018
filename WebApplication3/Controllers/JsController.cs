﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class JsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Objects()
        {
            return View();
        }
    }
}