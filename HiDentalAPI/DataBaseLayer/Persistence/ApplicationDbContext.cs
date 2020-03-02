using System;
using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Consultation> Consultation  { get; set; }
    }
}
