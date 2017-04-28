using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind_CRUD_frits.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to CRUD NorthWND DB";
            return View();
        }

    }
}