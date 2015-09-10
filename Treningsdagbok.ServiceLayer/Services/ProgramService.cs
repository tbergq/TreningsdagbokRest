using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.DAL.Interface;
using Treningsdagbok.DataLayer.Entities;
using Treningsdagbok.ServiceLayer.DTO;
using Treningsdagbok.ServiceLayer.Services.Interface;

namespace Treningsdagbok.ServiceLayer.Services
{
    public class ProgramService : BaseService<Program, DTOProgram>, IProgramService
    {
        private readonly IProgramRepository _programRepository;

        public ProgramService(IProgramRepository programRepository)
            : base(programRepository)
        {
            _programRepository = programRepository;
        }

        public IEnumerable<DTOProgram> GetAllProgramsFromUser(string userId)
        {
            return Mapper.Map<IEnumerable<DTOProgram>>(_programRepository.GetAllProgramsFromUser(userId));
        }
    }
}
