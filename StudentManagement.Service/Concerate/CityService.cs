using StudentManagement.DataEntity;
using StudentManagement.Repository.Conceate;
using StudentManagement.Repository.Interface;
using StudentManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Service.Concerate
{
    public class CityService : ICityService
    {
        ICityRepositroycs cityRepositroycs;
        public CityService()
        {
            cityRepositroycs = new CityRepositroy();
        }

        public List<CityMaster> GetCityMasters()
        {
            return cityRepositroycs.GetCityMasters();
        }
    }
}
