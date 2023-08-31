using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RegistroPersonas.Data;
using RegistroPersonas.Model;

namespace RegistroPersonas.Pages.Personas
{
    public class IndexModel : PageModel
    {
        private readonly RegistroPersonas.Data.RegistroPersonasContext _context;

        public IndexModel(RegistroPersonas.Data.RegistroPersonasContext context)
        {
            _context = context;
        }

        public IList<Persona> Persona { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Persona != null)
            {
                Persona = await _context.Persona.ToListAsync();
            }
        }
    }
}
