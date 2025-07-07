using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controllers
{
    public class ClassController : Controller
    {
        private readonly SchoolSysDbContext schoolSysDbContext;

        public ClassController(SchoolSysDbContext schoolSysDbContext)
        {
            this.schoolSysDbContext = schoolSysDbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var newClass = new ClassViewModel() {

                NewClass = new Class(),
                ClassList = schoolSysDbContext.Classes.ToList()

            }; 
            return View(newClass);
        }
         
        [HttpPost] 
        public IActionResult Index(ClassViewModel model)
        {
            if (model.NewClass != null)
            {
                if (model.NewClass.ClassId > 0)
                {
                    // EDIT
                    var existing = schoolSysDbContext.Classes.Find(model.NewClass.ClassId);
                    if (existing != null)
                    {
                        existing.ClassName = model.NewClass.ClassName;
                        existing.ModifiedDate = DateTime.Now;
                        schoolSysDbContext.SaveChanges();
                    }
                }
                else if (!string.IsNullOrWhiteSpace(model.NewClass.ClassName))
                {
                    // CREATE
                    model.NewClass.CreatedDate = DateTime.Now;
                    schoolSysDbContext.Classes.Add(model.NewClass);
                    schoolSysDbContext.SaveChanges();
                }
            }

            var latest = schoolSysDbContext.Classes.OrderByDescending(c => c.CreatedDate).First();
            return PartialView("_ClassListPartial", latest);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var cls = schoolSysDbContext.Classes.Find(id);
            if (cls != null)
            {
                schoolSysDbContext.Classes.Remove(cls);
                schoolSysDbContext.SaveChanges();
            }
            return Ok(); // for AJAX
        }


    }
}
