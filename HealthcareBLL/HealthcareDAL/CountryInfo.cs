using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareDAL
{
    public class CountryInfo
    {
        public int CountryCode { get; set; }
        public string CountryName { get; set; }
        public List<CountryInfo> GetCountryInfo()
        {
            string connectionDetails = ConfigurationManager.ConnectionStrings["HMSConfig"].ConnectionString;
            //string connectionDetails = @"data source = DESKTOP-8T682ON\SUMAN;database=Project;integrated security = true";
            List<CountryInfo> countryList = new List<CountryInfo>();
            using (SqlConnection connection = new SqlConnection(connectionDetails))
            {
                SqlCommand command = new SqlCommand(" select * from CountryInfo", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CountryInfo country = new CountryInfo();



                    country.CountryCode = Convert.ToInt32(reader["CountryCode"]);
                    country.CountryName = reader["CountryName"].ToString();
                    countryList.Add(country);
                }



            }
            return countryList;



        }
    }
}
