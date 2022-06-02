using StudentManagement.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Service.Interface
{
    public interface ICountryService
    {
        List<CountryMaster> GetCountryMasters();
    }
}
