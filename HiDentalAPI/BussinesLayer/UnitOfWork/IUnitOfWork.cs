using System.Threading.Tasks;
using BussinesLayer.Contracts;

namespace BussinesLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        IPatientService PatientService { get; }
        Task Commit();
    }
}