using DataLayer;
using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;
using System.Threading.Tasks;

namespace MVCBasics.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeRepository _repo;

        public EmployeeController(DataLayer.AppContext context)
        {
            _repo = new EmployeeRepository(context);
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
            return View(_repo.Index());
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeModel = _repo.Details(id);
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
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Mobile,City,Department")] EmployeeModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                _repo.Create(employeeModel);
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

            var employeeModel = await _repo.Find(id);
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
        public async Task<IActionResult> Edit(string id, [Bind("ID,FirstName,LastName,Mobile,City,Department")] EmployeeModel employeeModel)
        {
            if (id != employeeModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var result = _repo.Edit(id, employeeModel);
                if(result is null)
                {
                    return NotFound();
                }
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

            var employeeModel = await _repo.Find(id);
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
            _repo.DeleteConfirmed(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
