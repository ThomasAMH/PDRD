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
    public class IndexModel : PageModel
    {
        private readonly PDRD.Data.PDRDContext _context;

        public IndexModel(PDRD.Data.PDRDContext context)
        {
            _context = context;
        }

        public IList<Agenda> Agenda { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Agenda != null)
            {
                Agenda = await _context.Agenda.ToListAsync();
            }
        }
    }
}
