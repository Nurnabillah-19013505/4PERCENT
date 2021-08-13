using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYPFinalCode.Controllers
{
    public class ChapterController : Controller
    {
        public IActionResult ChapterPage()
        {
            return View();
        }
    }
}
