﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PhotOn.Web.Controllers
{
    public class AdminController : Controller
    {
        
        public IActionResult GetPublications()
        {
            return View();
        }
    }
}