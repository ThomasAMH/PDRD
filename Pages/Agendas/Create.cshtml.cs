using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PDRD.Data;
using PDRD.Models;
using Microsoft.EntityFrameworkCore;

namespace PDRD.Pages.Agendas
{
    public class CreateModel : PageModel
    {
        private readonly PDRD.Data.PDRDContext _context;

        public CreateModel(PDRD.Data.PDRDContext context)
        {
            _context = context;
        }

        // Define properties to hold the lists of Hymns and People
        public List<Hymn> AvailableHymns { get; set; }
        public List<Person> AvailablePeople { get; set; }

        public async Task OnGetAsync()
        {
            // Fetch the lists of Hymns and People from the database
            AvailableHymns = await _context.Hymns.ToListAsync();
            AvailablePeople = await _context.People.ToListAsync();
        }

        [BindProperty]
        public Agenda Agenda { get; set; } = default!;
        [BindProperty]
        public Talk NewTalk { get; set; }

        public List<Talk> NewTalks = new List<Talk>();
        public async Task<IActionResult> OnPostAddTalkAsync(string topic, int personID, Prefix PersonPrefix, string FirstName,string LastName)
        {
            if (!string.IsNullOrEmpty(topic))
            {
                // Add the talk to the local list or perform any necessary operations
                // Example: Talks.Add(new Talk { Topic = topic });
                NewTalk.PersonID = personID;
                NewTalk.Topic = topic;

                NewTalks.Add(NewTalk);

                // Fetch the lists of Hymns and People from the database
                AvailableHymns = await _context.Hymns.ToListAsync();
                AvailablePeople = await _context.People.ToListAsync();
            }

            return Page(); // Stay on the same page
        }
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Agenda == null || Agenda == null)
            {
                return Page();
            }

            //Agenda.OpeningHymn = await _context.Hymns.FirstOrDefaultAsync(h => h.HymnID == Agenda.OpeningHymnID);
            //Agenda.SacramentHymn = await _context.Hymns.FirstOrDefaultAsync(h => h.HymnID == Agenda.SacramentHymnID);
            //Agenda.IntermediateHymn = await _context.Hymns.FirstOrDefaultAsync(h => h.HymnID == Agenda.IntermediateHymnID);
            //Agenda.ClosingHymn = await _context.Hymns.FirstOrDefaultAsync(h => h.HymnID == Agenda.ClosingHymnID);

            Agenda.Talks = NewTalks;
            _context.Agenda.Add(Agenda);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
