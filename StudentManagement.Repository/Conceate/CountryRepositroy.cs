using StudentManagement.DataEntity;
using StudentManagement.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Repository.Conceate
{
    public class CountryRepositroy : ICountryRepositroy
    {

        public SqlConnection con;

        public CountryRepositroy()
        {
            string constr = ConfigurationManager.ConnectionStrings["studentConnection"].ToString();
            con = new SqlConnection(constr);
        }

        public List<CountryMaster> GetCountryMasters()
        {

            List<CountryMaster> EmpList = new List<CountryMaster>();
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("Select * from CountryMaster", con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.Open();
            da.Fill(dt);
            con.Close();


            foreach (DataRow dr in dt.Rows)
            {

                EmpList.Add(

                    new CountryMaster
                    {

                        CountryID = Convert.ToInt32(dr["CountryID"]),
                        CountryName = Convert.ToString(dr["CountryName"]),
                        

                    }
                    );
            }










            return EmpList;
        }
    }
}
