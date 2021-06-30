using System.Web.Mvc;

namespace PersonalSiteMVC.UI.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Links()
        {
            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Skills()
        {
            return View();
        }


        public ActionResult Projects()
        {
            return View();
        }


        public ActionResult projectDetails()
        {
            return View();
        }
    }
}
