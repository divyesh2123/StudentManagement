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
    public class CountryService : ICountryService
    {
        ICountryRepositroy countryRepositroy;
        public CountryService()
        {
             countryRepositroy = new CountryRepositroy();
        }

        public List<CountryMaster> GetCountryMasters()
        {
            return countryRepositroy.GetCountryMasters();
        }
    }
}
