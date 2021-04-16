using DataLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;
using System.Threading.Tasks;

namespace ApiLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {

        private readonly IBaseRepository<EmployeeModel> _repo;

        public EmployeeController(IBaseRepository<EmployeeModel> repo)
        {
            this._repo = repo;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repo.GetAll());
        }


        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> Get(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var employeeModel = await _repo.Get(id);
            if (employeeModel == null)
            {
                return NotFound();
            }

            return Ok(employeeModel);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                await _repo.Insert(employeeModel);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Put(EmployeeModel employeeModel)
        {
            if (string.IsNullOrEmpty(employeeModel.ID))
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _repo.Update(employeeModel);

                return Ok(employeeModel);
            }
            return BadRequest();
        }

        // GET: Employee/Delete/5
        [HttpDelete]
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
            await _repo.Delete(id);
            return Ok();
        }

    }
}
