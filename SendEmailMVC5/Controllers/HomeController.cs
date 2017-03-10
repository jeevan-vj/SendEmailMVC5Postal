using Postal;   
using System.Web.Mvc;

namespace SendEmailMVC5.Controllers
{
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
        public ActionResult SendMail()
        {
            dynamic email = new Email("Example");
            email.To = "jeevan90wijerathna@gmail.com";
            email.Message = "test by jeevan";
            email.Send();
            return View();
        }
    }
}