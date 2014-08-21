using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadFiles.Models;

namespace UploadFiles.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateJob()
        {
            return View(); 
        }

        [HttpPost]
        public ActionResult CreateJob(NewJobViewModel job)
        {
            if(ModelState.IsValid)
            {
                return View(job);
            }

            if (job.files.Any())
            {
                var files = job.files.Select(x => new { 
                    name = x.FileName, 
                    extension = x.ContentType, 
                    size = x.ContentLength 
                });
                ViewBag.UploadedFiles = job.files;
            }
            return View(job);
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
    }
}