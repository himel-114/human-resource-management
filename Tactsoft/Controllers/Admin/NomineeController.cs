using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class NomineeController : Controller
    {
        private readonly INomineeService _nomineeService;
        private readonly IEmployeeService _employeeService;
        private readonly IRelationShipService _relationShipService;

        public NomineeController(INomineeService nomineeService,IEmployeeService employeeService,IRelationShipService relationShipService)
        {
            this._nomineeService = nomineeService;
            this._employeeService = employeeService;
            this._relationShipService = relationShipService;
        }
        // GET: NomineeController
        public async Task<IActionResult> Index()
        {
            var nm = await _nomineeService.GetAllAsync(e => e.Employee, e => e.RelationShip);
            return View(nm);
        }

        // GET: NomineeController/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            var nm = await _nomineeService.FindAsync(x => x.Id == id, x => x.Employee, x => x.RelationShip);
            if (nm == null)
            {
                return NotFound();
            }
            return View(nm);
        }

        // GET: NomineeController/Create
        public ActionResult Create()
        {

            
            ViewData["EmployeeId"] = _employeeService.Dropdown();
            ViewData["RelationshipId"] = _relationShipService.Dropdown();
            
            return View();
        }

        // POST: NomineeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Nominee nominee, IFormFile pictureFile)
        {

            if (ModelState.IsValid)
            {
                if (pictureFile != null && pictureFile.Length > 0)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/employees",
                     pictureFile.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        pictureFile.CopyTo(stream);
                    }
                    nominee.Photo = $"{pictureFile.FileName}";
                }

                await _nomineeService.InsertAsync(nominee);
                TempData["successAlert"] = "save successfull.";
                return RedirectToAction(nameof(Index));
            }

            ViewData["EmployeeId"] = _employeeService.Dropdown();
            ViewData["RelationshipId"] = _relationShipService.Dropdown();

            TempData["errorAlert"] = "Operation failed.";
            return View(nominee);
        }

        // GET: NomineeController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var nm = await _nomineeService.FindAsync(x => x.Id == id, x => x.Employee, x => x.RelationShip);
            if (nm == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = _employeeService.Dropdown();
            ViewData["RelationshipId"] = _relationShipService.Dropdown();
            return View(nm);
        }

        // POST: NomineeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Nominee nominee, IFormFile pictureFile)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var emp = await _nomineeService.FindAsync(nominee.Id);

                    if (pictureFile != null && pictureFile.Length > 0)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/employees",
                         pictureFile.FileName);

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            pictureFile.CopyTo(stream);
                        }
                        nominee.Photo = $"{pictureFile.FileName}";
                    }
                    else
                    {
                        nominee.Photo = emp.Photo;
                    }
                    emp.Photo = nominee.Photo;
                    emp.EmployeeId = nominee.EmployeeId;
                    emp.NomineeName = nominee.NomineeName;
                    emp.RelationShipId = nominee.RelationShipId;
                    emp.Address = nominee.Address;
                    emp.ContactNumber = nominee.ContactNumber;
                    emp.percentage = nominee.percentage;
                    

                    await _nomineeService.UpdateAsync(emp);
                    TempData["successAlert"] = "update successfull.";
                }
                catch
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = _employeeService.Dropdown();
            ViewData["RelationshipId"] = _relationShipService.Dropdown();

            TempData["errorAlert"] = "Operation failed.";
            return View(nominee);
        }

        // GET: NomineeController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var nm = await _nomineeService.FindAsync(x => x.Id == id, x => x.Employee,e => e.RelationShip);
            if (nm == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = _employeeService.Dropdown();
            ViewData["RelationshipId"] = _relationShipService.Dropdown();

            return View(nm);
        }

        // POST: NomineeController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var nm = await _nomineeService.FindAsync(id);
                if (nm != null)
                {
                    await _nomineeService.DeleteAsync(nm);
                }
                TempData["successful"] = "delete successfully";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();

            }
        }
    }
}
