using StudentManagement.DataEntity;
using StudentManagement.Repository.Conceate;
using StudentManagement.Repository.Interface;
using StudentManagement.Service.Concerate;
using StudentManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentManagement.Controllers
{
    public class CityController : ApiController
    {
        // GET api/<controller>
        public List<CityMaster> Get()
        {
            ICityService cityService = new CityService();

            return cityService.GetCityMasters();

        }

       

       
    }
}