using StudentManagement.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Repository.Interface
{
    public interface ICityRepositroycs
    {
         List<CityMaster> GetCityMasters();

    }
}
