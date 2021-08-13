using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using FYPFinalCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;


namespace FYPFinalCode.Controllers
{
    public class MissionController : Controller
    {
        private IWebHostEnvironment _env;
        public MissionController(IWebHostEnvironment environment)
        {
            _env = environment;
        }



        public IActionResult Mission1()
        {
            return View();
        }

        public IActionResult MissionOnePost()
        {
            IFormCollection form = HttpContext.Request.Form;
            string Mission_Des = form["Mission_Des"].ToString().Trim();

            // Validate the user has entered all text fields
            if (ValidUtl.CheckIfEmpty(Mission_Des))
            {
                ViewData["Message"] = "Please enter all the fields";
                ViewData["MsgType"] = "Warning";
                return View("MissionOne");
            }

            else
            {
                return View("MissionPage");

            }
        }

            public IActionResult Mission2()
        {
            return View();
        }


        public IActionResult MissionTwoPost(IFormFile picture)
        {
            if (picture == null)
            {
                ViewData["Message"] = "Please select a quote to upload";
                ViewData["MsgType"] = "warning";
                return View("MissionTwo");
            }

            string fname = DoUploadPhoto(picture);


            return View("MissionPage");
        }


        public IActionResult Mission3()
        {
            return View();
        }

        public IActionResult Mission3Post(IFormFile picture)
        {
            if (picture == null)
            {
                ViewData["Message"] = "Please select a photo to upload";
                ViewData["MsgType"] = "warning";
                return View("Mission3");
            }

            string fname = DoUploadPhoto(picture);
            ViewData["Picture"] = fname;
            ViewData["Message"] = "Photo successfully posted";
            ViewData["MsgType"] = "success";

            return View("Mission3");
        }
        public IActionResult Mission4()
        {
            return View();
        }

        public IActionResult Mission4Post(IFormFile picture)
        {
            if (picture == null)
            {
                ViewData["Message"] = "Please select a photo to upload";
                ViewData["MsgType"] = "warning";
                return View("Mission4");
            }

            string fname = DoUploadPhoto(picture);
            ViewData["Picture"] = fname;
            ViewData["Message"] = "Photo successfully posted";
            ViewData["MsgType"] = "success";

            return View("Mission4");
        }


        public IActionResult Mission5()
        {
            return View();
        }
        public IActionResult Mission6()
        {
            return View();
        }

        public IActionResult Mission6Post(IFormFile picture)
        {
            if (picture == null)
            {
                ViewData["Message"] = "Please select a photo to upload";
                ViewData["MsgType"] = "warning";
                return View("Mission4");
            }

            string fname = DoUploadPhoto(picture);
            ViewData["Picture"] = fname;
            ViewData["Message"] = "Photo successfully posted";
            ViewData["MsgType"] = "success";

            return View();
        }


        private string DoUploadPhoto(IFormFile photo)
        {
            string fext = Path.GetExtension(photo.FileName);
            string uname = Guid.NewGuid().ToString();
            string picture = uname + fext;
            string fullpath = Path.Combine(_env.WebRootPath, "Photo/" + picture);
            FileStream fs = new FileStream(fullpath, FileMode.Create);
            photo.CopyTo(fs);
            fs.Close();
            return picture;
        }

        public IActionResult MissionPage(int count)
        {
            return View();
        }

        public IActionResult Mission7()
        {
            return View();

        }


        public IActionResult Mission7Posting(IFormFile ZoomPicture)
        {
            if (ZoomPicture == null)
            {
                ViewData["Message"] = "Please Upload a Photo";
                ViewData["MsgType"] = "warning";
                return View("Mission7");
            }

            string picture = DoUploadPhoto(ZoomPicture);
            ViewData["ZoomPicture"] = picture;
            ViewData["Message"] = "Photo have been uploaded successfully!";
            ViewData["MsgType"] = "success";
            ViewBag.ZP = ZoomPicture;


            return View("SubmitPage");
        }


        public IActionResult SubmitPage()
        {
            ViewData["new"] = ViewData["BTM"];
            //after done with SubmitPage, put action here
            // redirect back to the missionpage 
            // can use viewdata
            // cannot work: private const - st
            return RedirectToAction("MissionPage");
        }

    }
}
