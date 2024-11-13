using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestConnect.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFiles(HttpPostedFileBase fileImage)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    string path2 = "  ";
                    string fileName = "  ", extention = "  ";
                    if (fileImage != null)
                    {
                        string path =Path.Combine(Server.MapPath("~/Image/"),Path.GetFileName(fileImage.FileName));
                        fileName= Path.GetFileNameWithoutExtension(path);
                        extention=(fileName+extention);
                        fileImage.SaveAs(path);
                    }
                    Session["fileImage"] = path2;
                    ViewBag.fileStatus = "UpLoad file successfully";
                }
                catch(Exception)
                {
                    ViewBag.fileStatus = "Error while file uploading";
                }
            }
            return View("Index");
        }
    }
}