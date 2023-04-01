using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareDAL
{
    public class StateInfo
    {
        public int StateCode { get; set; }
        public string StateName { get; set; }
        public int CountryCode { get; set; }

        public List<StateInfo> GetStateInfo()
        {
            string connectionDetails = ConfigurationManager.ConnectionStrings["HMSConfig"].ConnectionString;
            //string connectionDetails = @"data source = DESKTOP-8T682ON\SUMAN;database=Project;integrated security = true";
            List<StateInfo> stateList = new List<StateInfo>();
            using (SqlConnection connection = new SqlConnection(connectionDetails))
            {
                SqlCommand command = new SqlCommand(" select * from StateInfo", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    StateInfo state = new StateInfo();



                    state.StateCode = Convert.ToInt32(reader["StateCode"]);
                    state.StateName = reader["StateName"].ToString();
                    state.CountryCode = Convert.ToInt32(reader["CountryCode"]);
                    stateList.Add(state);
                }



            }
            return stateList;



        }
    }
}
