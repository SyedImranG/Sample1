﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MembershipDEMO.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
