using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class ZipCodeController : Controller
    {
        private readonly IZipCodeService _zipCodeService;

        public ZipCodeController(IZipCodeService zipCodeService)
        {
            this._zipCodeService = zipCodeService;
        }
        // GET: ZipCodeController
        public async Task<IActionResult> Index()
        {
            var zipCodeService = await _zipCodeService.GetAllAsync();
            return View(zipCodeService);
        }

        // GET: ZipCodeController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var zipCode = await _zipCodeService.FindAsync(id);
            return View(zipCode);
        }

        // GET: ZipCodeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZipCodeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ZipCode zipCode)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _zipCodeService.InsertAsync(zipCode);
                }
                TempData["successful"] = "zipcode save successfully";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZipCodeController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var zipcode = await _zipCodeService.FindAsync(id);
            return View(zipcode);
        }

        // POST: ZipCodeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ZipCode zipCode)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _zipCodeService.UpdateAsync(zipCode);
                }
                TempData["successful"] = "zipcode update successfully";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZipCodeController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var zipcode = await _zipCodeService.FindAsync(id);
            return View(zipcode);
        }

        // POST: ZipCodeController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            try
            {
                var zipcode = await _zipCodeService.FindAsync(id);
                if (zipcode != null)
                {
                    await _zipCodeService.DeleteAsync(zipcode);
                }
                TempData["successful"] = "zipcode delete successfully";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
