using DataLayer;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class TeacherController : BaseController<TeacherModel>
    {
        public TeacherController(IBaseRepository<TeacherModel> repo) : base(repo)
        {
        }

    }
}
