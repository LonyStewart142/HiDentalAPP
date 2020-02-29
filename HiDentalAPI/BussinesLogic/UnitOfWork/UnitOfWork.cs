using System;
using System.Threading.Tasks;
using BussinesLogic.Contracts;
using BussinesLogic.Services;
using DataLayer.Persistence;

namespace BussinesLogic.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private PatientService _patientService;

        public UnitOfWork(ApplicationDbContext context) => _context = context;
        public IPatientService PatientService => _patientService ?? (_patientService = new PatientService(_context));


        async Task IUnitOfWork.Commit() => await _context.SaveChangesAsync();
    }
}
