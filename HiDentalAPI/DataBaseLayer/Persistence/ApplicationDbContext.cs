using System;
using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Consulta> Consultas  { get; set; }
    }
}
