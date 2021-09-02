using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        DBEntities db = new DBEntities();
        public ActionResult CountryMedalList()
        {
            //Set Country No
            int No = 1;

            var coutries = db.Countries.ToList().OrderByDescending(a => a.Athletes.Sum(x => x.MedalLists.Count(m => m.MedalType == 1))).ToList();
            coutries.ForEach(a =>
            {
                a.No = No++;
            });


            return View(coutries);
        }

        public ActionResult NewsDetail(int nid)
        {
            
            return View(db.News.Find(nid));
        }




    }
}