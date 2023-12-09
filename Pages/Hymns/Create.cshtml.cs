using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PDRD.Data;
using PDRD.Models;

namespace PDRD.Pages.Hymns
{
    public class CreateModel : PageModel
    {
        private readonly PDRD.Data.PDRDContext _context;

        public CreateModel(PDRD.Data.PDRDContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Hymn Hymn { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Hymn == null || Hymn == null)
            {
                return Page();
            }

            _context.Hymn.Add(Hymn);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
