using FYPFinalCode.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FYPFinalCode.Controllers
{
    public class PulseVentureController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public PulseVentureController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        private const string AUTHSCHEME = "Pulse";
        private const string LOGIN_VIEW = "StudentLogin";
        public IActionResult Homepage()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();

        }

        public IActionResult Mainpage()
        {
            return View();
        }

        public IActionResult ChoicePage()
        {
            return View();
        }
        public IActionResult PulseVentureHomepage()
        {
            return View();
        }

        public IActionResult ParentHomepage()
        {
            return View();
        }

        public IActionResult Introduction()
        {
            return View();
        }

        public IActionResult BattleMode()
        {
            return View();
        }

        public IActionResult CardDeck()
        {
            return View();
        }

        public IActionResult EndChapter()
        {
            return View();
        }

        public IActionResult Journal()
        {
            FileManagerModel model = new FileManagerModel();
            var userImagesPath = Path.Combine(_hostingEnvironment.WebRootPath, "Photo");
            DirectoryInfo dir = new DirectoryInfo(userImagesPath);
            FileInfo[] files = dir.GetFiles();
            model.Files = files;
            return View(model);
        }

    }
}
