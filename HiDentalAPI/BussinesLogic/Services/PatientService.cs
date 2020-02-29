using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BussinesLogic.Contracts;
using BussinesLogic.Repository.Services;
using DataLayer.Models;
using DataLayer.Persistence;

namespace BussinesLogic.Services
{
    public class PatientService : BaseRepository<Patient>,IPatientService
    {
        private readonly ApplicationDbContext _dbContext;
        public PatientService(ApplicationDbContext dbContext) : base(dbContext) => _dbContext = dbContext;
       
    }
}
