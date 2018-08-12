using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VMS.Models;

namespace VMS.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult AddVolunteer()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddVolunteer(UserAccount user)
        {
            UserAccountRepository.AddInput(user);
            return View( user);

        }



        public ViewResult ShowVolunteers()
        {
            return View(UserAccountRepository.Input);
        }

        
      
    }
}
