using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BarApp.Models;

namespace BarApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Orders()
        {
            using (OrderDBContext db = new OrderDBContext())
            {
                return View(db.menus.ToList());
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddDrinks()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDrinks(Menu menu)
        {
            if (ModelState.IsValid)
            {
                using (AppBarDBContext db = new AppBarDBContext())
                {
                    db.menus.Add(menu);
                    db.SaveChanges();
                }
                ModelState.Clear();

            }
            return View();

        }

        public ActionResult ViewDrink()
        {

            using (AppBarDBContext ab = new AppBarDBContext())
            {
                
                return View(ab.menus.ToList());
            }
        }
    }
}