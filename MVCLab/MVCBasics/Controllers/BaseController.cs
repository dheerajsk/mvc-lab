using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace MVCBasics.Controllers
{
    public class BaseController<T2> : Controller where T2 : BaseModel
    {

        private readonly IBaseRepository<T2> _repo;

        public BaseController(IBaseRepository<T2> repo)
        {
            this._repo = repo;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _repo.GetAll());
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeModel = await _repo.Get(id);
            if (employeeModel == null)
            {
                return NotFound();
            }

            return View(employeeModel);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(T2 employeeModel)
        {
            if (ModelState.IsValid)
            {
                await _repo.Insert(employeeModel);
                return RedirectToAction(nameof(Index));
            }
            return View(employeeModel);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeModel = await _repo.Get(id);
            if (employeeModel == null)
            {
                return NotFound();
            }
            return View(employeeModel);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, T2 employeeModel)
        {
            if (id != employeeModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _repo.Update(employeeModel);

                return RedirectToAction(nameof(Index));
            }
            return View(employeeModel);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeModel = await _repo.Get(id);
            if (employeeModel == null)
            {
                return NotFound();
            }

            return View(employeeModel);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await _repo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
