using Microsoft.AspNetCore.Mvc;
using WebAppMvc.Models;

namespace WebAppMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> lst = new List<Department>();
            lst.Add(new Department
            {
                Id = 1,
                Name = "Eletronics"
            });

            lst.Add(new Department
            {
                Id = 2,
                Name = "Fashion"
            });

            return View(lst);
        }
    }
}
