using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PDRD.Data;
using PDRD.Models;

namespace PDRD.Pages.Agendas
{
    public class DeleteModel : PageModel
    {
        private readonly PDRD.Data.PDRDContext _context;

        public DeleteModel(PDRD.Data.PDRDContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Agenda Agenda { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Agenda == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agenda.FirstOrDefaultAsync(m => m.AgendaID == id);

            if (agenda == null)
            {
                return NotFound();
            }
            else
            {
                Agenda = agenda;
                Agenda.OpeningHymn = await _context.Hymns.FirstOrDefaultAsync(h => h.HymnID == Agenda.OpeningHymnID);
                Agenda.SacramentHymn = await _context.Hymns.FirstOrDefaultAsync(h => h.HymnID == Agenda.SacramentHymnID);
                Agenda.IntermediateHymn = await _context.Hymns.FirstOrDefaultAsync(h => h.HymnID == Agenda.IntermediateHymnID);
                Agenda.ClosingHymn = await _context.Hymns.FirstOrDefaultAsync(h => h.HymnID == Agenda.ClosingHymnID);
                Agenda.OpeningPrayerPerson = await _context.People.FirstOrDefaultAsync(h => h.PersonID == Agenda.OpeningPrayerPersonID);
                Agenda.ClosingPrayerPerson = await _context.People.FirstOrDefaultAsync(h => h.PersonID == Agenda.ClosingPrayerPersonID);
                Agenda.PresidingPerson = await _context.People.FirstOrDefaultAsync(h => h.PersonID == Agenda.PresidingPersonID);
                Agenda.ConductingPerson = await _context.People.FirstOrDefaultAsync(h => h.PersonID == Agenda.ConductingPersonID);
            }
                
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Agenda == null)
            {
                return NotFound();
            }
            var agenda = await _context.Agenda.FindAsync(id);

            if (agenda != null)
            {
                Agenda = agenda;
                _context.Agenda.Remove(Agenda);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
