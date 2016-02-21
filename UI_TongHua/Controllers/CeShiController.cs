using CHG.Web.B_TongHua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHG.Web.UI_TongHua.Controllers
{
    public class CeShiController : Controller
    {
        ModelDatabase db = new ModelDatabase();

        // GET: CeShi
        public ActionResult Index()
        {
            var arrTongHuaLieBiao = db.e_tonghuaxinxi.ToList();
            return View(arrTongHuaLieBiao);
        }

        public ActionResult Modify()
        {
            return View();
        }
    }
}