using BussinesLayer.Contracts;
using BussinesLayer.Services;
using DatabaseLayer.Persistence;
using System.Threading.Tasks;

namespace BussinesLayer.UnitOfWork
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
