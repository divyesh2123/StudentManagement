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
    public class StateRespositroy : IStateRespositroy
    {

        public SqlConnection con;

        public StateRespositroy()
        {
            string constr = ConfigurationManager.ConnectionStrings["studentConnection"].ToString();
            con = new SqlConnection(constr);
        }

        public List<StateMaster> GetStateMasters()
        {
            List<StateMaster> EmpList = new List<StateMaster>();
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("Select * from StateMaster", con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.Open();
            da.Fill(dt);
            con.Close();


            foreach (DataRow dr in dt.Rows)
            {

                EmpList.Add(

                    new StateMaster
                    {

                        StateId = Convert.ToInt32(dr["CityID"]),
                        StateName = Convert.ToString(dr["CityName"]),
                        CountryID = Convert.ToInt32(dr["CountryID"]),

                    }
                    );
            }










            return EmpList;

        }
       
    }
}
