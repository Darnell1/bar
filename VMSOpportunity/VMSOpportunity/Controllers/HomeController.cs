using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VMSOpportunity.Models;

namespace VMSOpportunity.Controllers
{
    public class VOController : Controller
    {
        public ActionResult Index()
        {
            using (VolunteerOpportunityDBContext db = new VolunteerOpportunityDBContext())
            {
                return View(db.VO.ToList());
            }
        }

        public ActionResult AddOpportunity()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOpportunity(VolunteerOpportunity vo)
        {
            if (ModelState.IsValid)
            {
                using (VolunteerOpportunityDBContext db = new VolunteerOpportunityDBContext())
                {
                    db.VO.Add(vo);
                    db.SaveChanges();
                }
                ModelState.Clear();

            }
            return View();


        }
    }
}