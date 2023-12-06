using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _178757module03_razorpage.Data;
using _178757module03_razorpage.Models;

namespace _178757module03_razorpage.Pages
{
    public class CreateModel : PageModel
    {
        private readonly _178757module03_razorpage.Data.ApplicationDbContext _context;

        public CreateModel(_178757module03_razorpage.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Employees == null || Employee == null)
            {
                return Page();
            }

            _context.Employees.Add(Employee);

           await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
