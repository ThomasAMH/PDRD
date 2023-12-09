using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PDRD.Data;
using PDRD.Models;

namespace PDRD.Pages.Hymns
{
    public class EditModel : PageModel
    {
        private readonly PDRD.Data.PDRDContext _context;

        public EditModel(PDRD.Data.PDRDContext context)
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

            var hymn =  await _context.Hymn.FirstOrDefaultAsync(m => m.HymnID == id);
            if (hymn == null)
            {
                return NotFound();
            }
            Hymn = hymn;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Hymn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HymnExists(Hymn.HymnID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HymnExists(int id)
        {
          return (_context.Hymn?.Any(e => e.HymnID == id)).GetValueOrDefault();
        }
    }
}
