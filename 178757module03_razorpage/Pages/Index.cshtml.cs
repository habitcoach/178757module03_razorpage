using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _178757module03_razorpage.Data;
using _178757module03_razorpage.Models;

namespace _178757module03_razorpage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly _178757module03_razorpage.Data.ApplicationDbContext _context;

        public IndexModel(_178757module03_razorpage.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employees != null)
            {
                Employee = await _context.Employees.ToListAsync();
            }
        }
    }
}
