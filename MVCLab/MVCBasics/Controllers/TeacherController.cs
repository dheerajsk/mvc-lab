using DataLayer;
using Microsoft.AspNetCore.Authorization;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    [Authorize()]
    public class TeacherController : BaseController<TeacherModel>
    {
        public TeacherController(IBaseRepository<TeacherModel> repo) : base(repo)
        {
        }

    }
}
