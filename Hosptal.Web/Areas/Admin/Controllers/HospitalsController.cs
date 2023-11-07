using Microsoft.AspNetCore.Mvc;

namespace Hosptal.Web.Areas.Admin.Controllers
{
    public class HospitalsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
