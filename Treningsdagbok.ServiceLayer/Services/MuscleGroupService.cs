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
    public class MuscleGroupService : BaseService<MuscleGroup, DTOMuscleGroup>, IMuscleGroupService
    {
        private readonly IMuscleGroupRepository _muscleGroupRepository;

        public MuscleGroupService(IMuscleGroupRepository muscleGroupRepository) : 
            base(muscleGroupRepository)
        {
            _muscleGroupRepository = muscleGroupRepository;
        }
    }
}
