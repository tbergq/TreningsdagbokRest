using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Treningsdagbok.DataLayer.DAL.Interface;
using Treningsdagbok.DataLayer.Entities;
using Treningsdagbok.ServiceLayer.DTO;
using Treningsdagbok.ServiceLayer.Services.Interface;


namespace Treningsdagbok.ServiceLayer.Services
{
    public class ProgramService : BaseService<Program, DTOProgram>, IProgramService
    {
        private readonly IProgramRepository _programRepository;
        private readonly IWeekService _weekService;

        public ProgramService(IProgramRepository programRepository, IWeekService weekService)
            : base(programRepository)
        {
            _programRepository = programRepository;
            _weekService = weekService;
        }

        public IEnumerable<DTOProgram> GetAllProgramsFromUser(string userId)
        {
            return Mapper.Map<IEnumerable<DTOProgram>>(_programRepository.GetAllProgramsFromUser(userId));
        }

        public override DTOProgram GetById(int id)
        {
            using (var scope = new TransactionScope())
            {
                var program = Mapper.Map<DTOProgram>(_programRepository .GetById(id));
                program.Weeks = _weekService.GetAllWeeksOfProgram(id).ToList();
                return program;
            }
        }
    }
}
