using DataLayer;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class StudentController : BaseController<StudentModel>
    {

        public StudentController(IBaseRepository<StudentModel> repo) : base(repo)
        {
        }

    }
}
