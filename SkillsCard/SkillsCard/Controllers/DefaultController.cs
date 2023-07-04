using SkillsCard.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillsCard.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        CONTEXT c=new CONTEXT();
        public ActionResult Index()
        {
            var degerler = c.YETENEKLERS.ToList();
            return View(degerler);
        }
    }
}