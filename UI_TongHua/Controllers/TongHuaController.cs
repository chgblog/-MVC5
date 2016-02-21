using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CHG.Web.B_TongHua.Models;

namespace CHG.Web.UI_TongHua.Controllers
{
    public class TongHuaController : Controller
    {
        private ModelDatabase db = new ModelDatabase();

        // GET: TongHua
        public ActionResult Index()
        {
            Session["LoginName"] = "CHG";
            return View(db.e_tonghuaxinxi.Where(TongHuaXinXi => TongHuaXinXi.ZhuangTai!=2).ToList());
        }

        // GET: TongHua/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            e_tonghuaxinxi e_tonghuaxinxi = db.e_tonghuaxinxi.Find(id);
            if (e_tonghuaxinxi == null)
            {
                return HttpNotFound();
            }
            return View(e_tonghuaxinxi);
        }

        // GET: TongHua/Create
        public ActionResult Create()
        {
            return View(new e_tonghuaxinxi());
        }

        // POST: TongHua/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TongHuaID,TongHuaBiaoTi,TongHuaNeiRong,TongHuaLeiBieID,PaiXu")] e_tonghuaxinxi e_tonghuaxinxi)
        {
            if (ModelState.IsValid)
            {
                db.e_tonghuaxinxi.Add(e_tonghuaxinxi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorInfo = "信息验证失败";
            }

            return View(e_tonghuaxinxi);
        }

        // GET: TongHua/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            e_tonghuaxinxi e_tonghuaxinxi = db.e_tonghuaxinxi.Find(id);
            if (e_tonghuaxinxi == null)
            {
                return HttpNotFound();
            }
            return View(e_tonghuaxinxi);
        }

        // POST: TongHua/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TongHuaID,TongHuaBiaoTi,TongHuaNeiRong,TongHuaLeiBieID,PaiXu,ZhuangTai")] e_tonghuaxinxi e_tonghuaxinxi)
        {
            if (ModelState.IsValid)
            {
                /*
                db.e_tonghuaxinxi.Attach(e_tonghuaxinxi);
                var entry = db.Entry(e_tonghuaxinxi);
                entry.Property(e => e.TongHuaBiaoTi).IsModified = true;
                entry.Property(e => e.TongHuaNeiRong).IsModified = true;
                entry.Property(e => e.TongHuaLeiBieID).IsModified = true;
                entry.Property(e => e.PaiXu).IsModified = true;
                db.SaveChanges();
                */
                db.Entry(e_tonghuaxinxi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorInfo = "信息验证失败";
            }
            return View(e_tonghuaxinxi);
        }

        // GET: TongHua/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            e_tonghuaxinxi e_tonghuaxinxi = db.e_tonghuaxinxi.Find(id);
            if (e_tonghuaxinxi == null)
            {
                return HttpNotFound();
            }
            return View(e_tonghuaxinxi);
        }

        // POST: TongHua/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            e_tonghuaxinxi e_tonghuaxinxi = db.e_tonghuaxinxi.Find(id);
            e_tonghuaxinxi.ZhuangTai = 2;
            db.SaveChanges();
            /*
            db.Entry(e_tonghuaxinxi).State = EntityState.Modified;
            db.SaveChanges();
            */
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
