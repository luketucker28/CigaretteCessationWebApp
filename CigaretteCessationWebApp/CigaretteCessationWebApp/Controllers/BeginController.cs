using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
//using System.Web.Http;
using System.ComponentModel.DataAnnotations;
namespace CigaretteCessationWebApp.Controllers
{
    public class BeginController : Controller
    {
        // GET: App
        [Authorize]
        public ActionResult Index()
        {
            ViewBag.UserId = User.Identity.GetUserId();
            return View();
        }
    }
}