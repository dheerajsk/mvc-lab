using DataLayer;
using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;
using System.Threading.Tasks;

namespace MVCBasics.Controllers
{
    public class EmployeeController : BaseController<EmployeeModel>
    {

        public EmployeeController(IBaseRepository<EmployeeModel> repo) : base(repo)
        {
        }

    }
}
