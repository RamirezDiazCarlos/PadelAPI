using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Data
{
    public class PadelDbContext : DbContext
    {
        public PadelDbContext(DbContextOptions<PadelDbContext> options) : base(options)
        {
        }
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Cancha> Canchas { get; set; }
        public DbSet<Club> Clubes { get; set; }
        public DbSet<Turno> Turnos { get; set; }

        
    }
}

