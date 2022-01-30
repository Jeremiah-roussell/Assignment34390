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
    public class IndexModel : PageModel
    {
        private readonly Assignment3.Models.DeliveryCartDbContext _context;

        public IndexModel(Assignment3.Models.DeliveryCartDbContext context)
        {
            _context = context;
        }

        public IList<Driver> Driver { get;set; }

        public async Task OnGetAsync()
        {
            Driver = await _context.Drivers.ToListAsync();
        }
    }
}
