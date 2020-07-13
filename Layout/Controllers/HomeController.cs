using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View_Layouts_Nested_Sections.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Testarea()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}
/*
 Web sayfamızda sabit olarak kullanacağımız  elementler için "Shared" adlı yeni bir dosya oluşturuyoruz. Views klasörü -> sağ tık -> add -> new folder ="Shared"
 Shared dosyasına sağ tıklayıp MVC için layoutpage(Razor) oluşturuyoruz.
 */