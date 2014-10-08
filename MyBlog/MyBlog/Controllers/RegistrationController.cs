using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class RegistrationController : Controller
    {

        //set uo my data context 
        Models.Blog.Entities db = new Models.Blog.Entities

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Models.Registration registration , HttpPostedFile ImageUrl)
        {
            if (ImageUrl != null)

        }
        //save the immage to our database

        {
            return View();
        }
        //
        // GET: /Registration/

        public ActionResult Index()
        {
            return View();
        }

    }
}
