using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FYPFinalCode.Models;
using Microsoft.AspNetCore.Mvc;

namespace FYPFinalCode.Controllers
{
    public class CardDeckController : Controller
    {
        public IActionResult Index()
        {
            List<CardDeck> lstCardDeck = DBUtl.GetList<CardDeck>("SELECT * FROM CardDeck ORDER BY Card_Tier");
            return View(lstCardDeck);
        }

        public IActionResult Display(int id)
        {
            string sql = String.Format(@"SELECT * FROM CardDeck 
                                       WHERE Card_Id = {0}", id);
            List<CardDeck> lstCardDeck = DBUtl.GetList<CardDeck>(sql);
            if (lstCardDeck.Count == 0)
            {
                TempData["Message"] = $"Card deck #{id} not found";
                TempData["MsgType"] = "warning";
                return RedirectToAction("Index");
            }
            else
            {
                // Get the FIRST element of the List
                CardDeck cd = lstCardDeck[0];
                return View(cd);
            }
        }
    }
}