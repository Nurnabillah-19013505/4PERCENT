using FYPFinalCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP.Controllers
{
    public class BattleModeController : Controller
    {
        private FYPdbcontext _dbContext;
        private int currid = 0;

        public BattleModeController(FYPdbcontext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CardGen()
        {

            DbSet<CardDeck> dbs = _dbContext.CardDeck;
            
            Random rand = new Random();
            int newrand = 0;
            //get total count from database
            //int ranID = $"SELECT COUNT(*) FROM CardDeck WHERE Card_Id ='{newrand}'";
            
            newrand = rand.Next(1, 6);

            //int newrand = rand.Next(1, <total count>);
            //if (DBUtl.GetTable(ranID).Rows.Count > 0)
            // {
            //var ranID = dbs.Where(mo => mo.CardId == newrand).FirstOrDefault();
            ViewData["RANID"] = newrand;
            currid = newrand;
            newrand = rand.Next(1, 6);
            ViewData["RANID2"] = newrand;


            return View();
        }

        public IActionResult CardPDF(int id)
        {
            DbSet<CardDeck> dbs = _dbContext.CardDeck;

            CardDeck model = dbs.Where(mo => mo.CardId == id).FirstOrDefault();

            if (model!=null)
            {
                return new ViewAsPdf(model)
                {
                    PageSize = Rotativa.AspNetCore.Options.Size.A4,
                    PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape
                };
            }
               
            else
            {
                ViewData["Msg"] = "ERROR OCCURED CONTACT!"+currid;
                return RedirectToAction("Index");
            }

        }

    }
}
