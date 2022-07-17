using EmployeeRazor.Data;
using EmployeeRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeRazor.Pages.Employees
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Employee Employee { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Employee = _db.Employee.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            var categoryFromDb = _db.Employee.Find(Employee.EmployeeId);
            if (categoryFromDb != null)
            {
                _db.Employee.Remove(categoryFromDb);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category deleted successfully";
                return RedirectToPage("Index");

            }

            return Page();
        }
    }
}
