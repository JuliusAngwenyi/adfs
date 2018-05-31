using JuliusA.MyFirstADFSWebApp.Helpers;
using JuliusA.MyFirstADFSWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace JuliusA.MyFirstADFSWebApp.Controllers
{
    [Authorize]
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
        public ActionResult UserClaims()
        {
            var principal = IdentityHelper.GetCurrentClaimsPrincipal();

            // temporary code to show user claims, while there is a sitecore user object as
            UserClaimsModel ucm = new UserClaimsModel();
            if (principal != null)
            {
                ucm.Claims = ((ClaimsPrincipal)principal).Claims;
            }
            ViewBag.Title = "ADFS Claims page";
            return View(ucm);
        }
    }
}