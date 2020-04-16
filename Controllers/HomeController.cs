using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyVal.Models;

namespace DojoSurveyVal.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [HttpGet]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("display")]
        public IActionResult Display(Survey userSurvey)
        {
            if(ModelState.IsValid)
            {
                return View("Display", userSurvey);
            }
            else
            {
                return View("Index");
            }
        }

        // [Route("display")]
        // [HttpGet]
        // public IActionResult Success()
        // {
        //     return View("Display");
        // }

    }
}
