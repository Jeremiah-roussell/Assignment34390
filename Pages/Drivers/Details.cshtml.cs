using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;

namespace Assignment3.Pages_Drivers
{
    public class DetailsModel : PageModel
    {
        private readonly Assignment3.Models.DeliveryCartDbContext _context;

        public DetailsModel(Assignment3.Models.DeliveryCartDbContext context)
        {
            _context = context;
        }

        public Driver Driver { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Driver = await _context.Drivers.FirstOrDefaultAsync(m => m.DriverID == id);

            if (Driver == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
