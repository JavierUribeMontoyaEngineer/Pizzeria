using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
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

        [AllowAnonymous]
        public ActionResult Token()
        {
            var payload = new Dictionary<string, string>()
            {
                {"sub", "123456780090"},
                {"name", "John"}
            };
            var token = TokenJWTService.Encode(payload);
            var s = new StringBuilder("window.token='");
            s.Append(token).Append("'");
            return JavaScript(s.ToString());
        }

    }
}