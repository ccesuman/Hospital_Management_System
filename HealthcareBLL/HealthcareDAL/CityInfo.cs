using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareDAL
{
    public class CityInfo
    {
        public int CityCode { get; set; }
        public string CityName { get; set; }
        public int StateCode { get; set; }
        public List<CityInfo> GetCityInfo()
        {
            string connectionDetails = ConfigurationManager.ConnectionStrings["HMSConfig"].ConnectionString;
            //string connectionDetails = @"data source = DESKTOP-8T682ON\SUMAN;database=Project;integrated security = true";
            List<CityInfo> cityList = new List<CityInfo>();
            using (SqlConnection connection = new SqlConnection(connectionDetails))
            {
                SqlCommand command = new SqlCommand(" select * from CityInfo", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CityInfo city = new CityInfo();



                    city.CityCode = Convert.ToInt32(reader["CityCode"]);
                    city.CityName = reader["CityName"].ToString();
                    city.StateCode = Convert.ToInt32(reader["StateCode"]);
                    cityList.Add(city);
                }



            }
            return cityList;



        }
    }
}
