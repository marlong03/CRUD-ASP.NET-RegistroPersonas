using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroPersonas.Model;

namespace RegistroPersonas.Data
{
    public class RegistroPersonasContext : DbContext
    {
        //Contructor
        public RegistroPersonasContext (DbContextOptions<RegistroPersonasContext> options)
            : base(options)
        {
        }
        //Representa la coleccion de Persona en DB
        public DbSet<RegistroPersonas.Model.Persona> Persona { get; set; } = default!;
    }
}
