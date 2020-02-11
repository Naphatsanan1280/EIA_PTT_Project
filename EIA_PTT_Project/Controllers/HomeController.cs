using Rotativa;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace EIA_PTT_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Map()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Map(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string fileName = Path.GetFileName(file.FileName);
                string path = Path.Combine(Server.MapPath("/UploadedFiles"), fileName);
                file.SaveAs(path);
            }

            return RedirectToAction("Map");
        }

        public ActionResult Getsample()
        {

            return View();
        }

        public ActionResult Print()
        {
            DateTime datetime = DateTime.Now;
            datetime.ToString("MM/dd/yyyy HH:mm");
            return new ActionAsPdf("Getsample", new { nombre = "Pedrito" })
            {
                FileName = "EIA" + datetime + ".pdf"
            };
        }



    }
}