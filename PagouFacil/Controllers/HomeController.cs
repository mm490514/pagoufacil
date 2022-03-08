using PagouFacil.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PagouFacil.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Marvel Api = new Marvel();
            var result = Api.GetPersonagens(); 
            
            return View();
        }

        
    }
}