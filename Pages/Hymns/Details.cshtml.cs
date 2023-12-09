using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PDRD.Data;
using PDRD.Models;

namespace PDRD.Pages.Hymns
{
    public class DetailsModel : PageModel
    {
        private readonly PDRD.Data.PDRDContext _context;

        public DetailsModel(PDRD.Data.PDRDContext context)
        {
            _context = context;
        }

      public Hymn Hymn { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Hymn == null)
            {
                return NotFound();
            }

            var hymn = await _context.Hymn.FirstOrDefaultAsync(m => m.HymnID == id);
            if (hymn == null)
            {
                return NotFound();
            }
            else 
            {
                Hymn = hymn;
            }
            return Page();
        }
    }
}
