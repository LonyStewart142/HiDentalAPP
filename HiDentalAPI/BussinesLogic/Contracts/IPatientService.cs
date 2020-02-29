using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BussinesLogic.Repository.Contracts;
using DataLayer.Models;

namespace BussinesLogic.Contracts
{
    public interface IPatientService : IBaseRepository<Patient>
    {
      
    }
}
