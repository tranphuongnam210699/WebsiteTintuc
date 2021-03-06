﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using websitestintuc.Models;

namespace websitestintuc.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        DataWebTinTucDataContext db = new DataWebTinTucDataContext();

        private List<TinTuc> LayTinMoi(int count)
        {
            return db.TinTucs.OrderByDescending(a => a.dateup).Take(count).ToList();
        }

        public ActionResult categories()
        {
            var categories = from cd in db.categories select cd;
            return PartialView(categories);
        }

        public ActionResult getNewsCategories(int id)
        {
            var tinmoi = from s in db.TinTucs where s.IDcategory == id select s;
            var displayName = from a in db.categories where a.ID == id select a.CategoryName;
            return View(tinmoi);
        }

        public ActionResult topList()
        {
            var topList = from s in db.TinTucs where s.topList == true select s;
            return View(topList);
        }

        public ActionResult Index()
        {
            var tinMoi = LayTinMoi(100);
            return View(tinMoi);
        }
        
    }
}