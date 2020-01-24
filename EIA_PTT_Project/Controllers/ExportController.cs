using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EIA_PTT_Project.Controllers
{
    public class ExportController : Controller
    {
        // GET: Export
        public ActionResult Index()
        {


            return View();
        }
        public ActionResult ExportFile()
        {
           
            return View();
        }

        
    }
}