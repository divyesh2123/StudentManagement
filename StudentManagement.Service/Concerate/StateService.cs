using StudentManagement.DataEntity;
using StudentManagement.Repository.Conceate;
using StudentManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Service.Concerate
{
    public class StateService : IStateService
    {
        StateRespositroy stateRespositroy;
        public StateService()
        {
            stateRespositroy = new StateRespositroy();
        }
        public List<StateMaster> GetStateMasters()
        {
            return stateRespositroy.GetStateMasters();
           
        }
    }
}
