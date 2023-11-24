using Hospital.Services;
using Hospital.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hosptal.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HospitalsController : Controller
    {
        private readonly IHospitalInfo _hospitalInfo;

        public HospitalsController(IHospitalInfo hospitalInfo)
        {
            _hospitalInfo = hospitalInfo;
        }

        public IActionResult Index(int pageNumber=1, int pageSize=10)
        {
            return View(_hospitalInfo.GetAll(pageNumber,pageSize));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var viewModel = _hospitalInfo.GetHositalById(id);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(HospitalInfoViewModel vm)
        {
            _hospitalInfo.UpdateHospitalInfo(vm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HospitalInfoViewModel vm)
        {
            _hospitalInfo.InsertHosipalInfo(vm);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _hospitalInfo.DeleteHosipalInfo(id);
            return RedirectToAction("Index");
        }
        

    }
}
