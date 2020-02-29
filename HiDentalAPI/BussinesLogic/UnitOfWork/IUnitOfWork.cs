using System.Threading.Tasks;
using BussinesLogic.Contracts;

namespace BussinesLogic.UnitOfWork
{
    public interface IUnitOfWork
    {
        IPatientService PatientService { get; }
        Task Commit();
    }
}