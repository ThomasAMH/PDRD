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
    public class DeleteModel : PageModel
    {
        private readonly PDRD.Data.PDRDContext _context;

        public DeleteModel(PDRD.Data.PDRDContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Hymn == null)
            {
                return NotFound();
            }
            var hymn = await _context.Hymn.FindAsync(id);

            if (hymn != null)
            {
                Hymn = hymn;
                _context.Hymn.Remove(Hymn);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
