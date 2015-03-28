using System.Web;
using System.Web.Mvc;
using WebMvcAjax.Models;

namespace WebMvcAjax.Controllers
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetReport(HttpPostedFileBase file, DataType dataType)
        {
            return new JsonResult {Data = dataType + file.ContentType};
        }
    }
}