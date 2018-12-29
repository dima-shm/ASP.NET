using NewVideo1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewVideo1.Controllers
{
    public class VideoController : Controller
    {
        VideoContext context = new VideoContext();
        
        public ActionResult Index()
        {
            string[] mas = Directory.GetFiles(Request.PhysicalApplicationPath + "Video");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Path.GetFileName(mas[i]);
            }
            ViewBag.Catalogs = mas;
            return View("Index");
        }

        public FileStreamResult GetFile(string name)
        {
            string path = Request.PhysicalApplicationPath + "Video\\" + name;
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            return new FileStreamResult(fileStream, "video/mp4");
        }

        public ActionResult GetVideo(string name)
        {
            ViewBag.VideoName = name;
            return View("GetVideo");
        }

        public ActionResult Upload(HttpPostedFileBase upload)
        {
            if (upload != null)
            {
   
                string fileName = Path.GetFileName(upload.FileName);

                upload.SaveAs(Server.MapPath("~/Video/" + fileName));
            }
            return RedirectToAction("Index");
        }
    }
}