using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FBLoginDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult GetUsers(string accessToken)
        {
            //擺token
            var client = new FacebookClient(accessToken);
            //取得json格式的資訊和需要的fields
            dynamic result = client.Get("me", new { fields = "name,id" });
            string name = result.name;
            string id = result.id;

            ViewBag.name = name;
            ViewBag.id = id;

            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "您的應用程式描述頁面。";

            return View();
        }

        public ActionResult Contact()
        {

        
            return View();
        }

    }
}
