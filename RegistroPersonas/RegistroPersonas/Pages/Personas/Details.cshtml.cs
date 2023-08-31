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
    public class DetailsModel : PageModel
    {
        private readonly RegistroPersonas.Data.RegistroPersonasContext _context;

        public DetailsModel(RegistroPersonas.Data.RegistroPersonasContext context)
        {
            _context = context;
        }

      public Persona Persona { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Persona == null)
            {
                return NotFound();
            }

            var persona = await _context.Persona.FirstOrDefaultAsync(m => m.id == id);
            if (persona == null)
            {
                return NotFound();
            }
            else 
            {
                Persona = persona;
            }
            return Page();
        }
    }
}
