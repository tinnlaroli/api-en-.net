using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Persistence
{
    public class HealthDbContext : DbContext
    {
        // se esta inyectando la configuracion de la base de datos en el constructor
        public HealthDbContext(DbContextOptions<HealthDbContext> options) : base(options) 
        {
        
        }

        // aqui lo que permite es crear las tablas en la base de datos a partir de
        // las entidades que se encuentran en el proyecto Domain
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
