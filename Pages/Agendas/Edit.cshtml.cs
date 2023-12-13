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
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PDRD.Pages.Agendas
{
    public class EditModel : PageModel
    {
        private readonly PDRD.Data.PDRDContext _context;

        public EditModel(PDRD.Data.PDRDContext context)
        {
            _context = context;
        }

        // Define properties to hold the lists of Hymns and People
        public List<Hymn> AvailableHymns { get; set; }
        public List<Person> AvailablePeople { get; set; }
        [BindProperty]
        public Agenda Agenda { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Agenda == null)
            {
                return NotFound();
            }
            /* Aqui empiezan los cambios */
            var agenda = await _context.Agenda
                            .Include(a => a.Talks)
                            .FirstOrDefaultAsync(m => m.AgendaID == id);
            /* Aqui terminan los cambios */
            if (agenda == null)
            {
                return NotFound();
            }
            Agenda = agenda;
            // Fetch the lists of Hymns and People from the database
            AvailableHymns = await _context.Hymns.ToListAsync();
            AvailablePeople = await _context.People.ToListAsync();

            Agenda.OpeningHymn = await _context.Hymns.FirstOrDefaultAsync(h => h.HymnID == Agenda.OpeningHymnID);
            Agenda.SacramentHymn = await _context.Hymns.FirstOrDefaultAsync(h => h.HymnID == Agenda.SacramentHymnID);
            Agenda.IntermediateHymn = await _context.Hymns.FirstOrDefaultAsync(h => h.HymnID == Agenda.IntermediateHymnID);
            Agenda.ClosingHymn = await _context.Hymns.FirstOrDefaultAsync(h => h.HymnID == Agenda.ClosingHymnID);
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

            _context.Attach(Agenda).State = EntityState.Modified;
            /* Aqui empiezan los cambios */
            if (Agenda.Talks != null)
            {
                foreach (var talk in Agenda.Talks)
                {
                    if (talk.TalkID == 0) // This is a new talk
                    {
                        _context.Talks.Add(talk);
                    }
                    else // This is an existing talk
                    {
                        _context.Attach(talk).State = EntityState.Modified;
                    }
                }
            }
            /* Aqui terminan los cambios */

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgendaExists(Agenda.AgendaID))
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

        private bool AgendaExists(int id)
        {
            return (_context.Agenda?.Any(e => e.AgendaID == id)).GetValueOrDefault();
        }
    }
}
