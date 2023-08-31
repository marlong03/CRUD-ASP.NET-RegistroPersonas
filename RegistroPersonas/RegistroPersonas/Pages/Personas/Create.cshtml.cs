using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RegistroPersonas.Data;
using RegistroPersonas.Model;

namespace RegistroPersonas.Pages.Personas
{   
    //PageModel nos da los metodos necesarios para realizar las operaciones crud
    public class CreateModel : PageModel
    {
        private readonly RegistroPersonas.Data.RegistroPersonasContext _context;
        //Nos trae la conexion de la BD con RegistroPersonasContext
        public CreateModel(RegistroPersonas.Data.RegistroPersonasContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        //Objeto a rellenar par enviar a la BD
        [BindProperty]
        public Persona Persona { get; set; } = default!;
        

        //Metodo que nos proporcion  Razor para guardar datos en la BD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Persona == null || Persona == null)
            {
                return Page();
            }

            _context.Persona.Add(Persona);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
