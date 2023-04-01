using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareDAL
{
    /// <summary>
    /// here reading the infomation from database of HospitalInfo table
    /// </summary>
    public class HospitalInfo
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string PrimaryAddress { get; set; }
        public string SecondaryAddress { get; set; }
        public int PinCode { get; set; }
        public int Departments { get; set; }
        public int TotalRoom { get; set; }
        public int FunctionalRoom { get; set; }
        public int TotalDoctors { get; set; }
        public int CityCode { get; set; }
        public int CountryCode { get; set; }
        public int StateCode { get; set; }


        public List<HospitalInfo> GetHospitalInfo()
        {
            string connectionDetails = ConfigurationManager.ConnectionStrings["HMSConfig"].ConnectionString;
           
            List<HospitalInfo> hospitalList = new List<HospitalInfo>();
            using (SqlConnection connection = new SqlConnection(connectionDetails))
            {
                SqlCommand command = new SqlCommand("select * from HospitalInfo", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    HospitalInfo hospital = new HospitalInfo();

                    hospital.HospitalId = Convert.ToInt32(reader["HospitalId"]);
                    hospital.HospitalName = reader["HospitalName"].ToString();
                    hospital.PrimaryAddress = reader["PrimaryAddress"].ToString();
                    hospital.SecondaryAddress = reader["SecondaryAddress"].ToString();
                    hospital.PinCode = Convert.ToInt32(reader["PinCode"]);
                    hospital.Departments = Convert.ToInt32(reader["Departments"]);
                    hospital.TotalRoom = Convert.ToInt32(reader["TotalRoom"]);
                    hospital.FunctionalRoom = Convert.ToInt32(reader["FunctionalRoom"]);
                    hospital.TotalDoctors = Convert.ToInt32(reader["TotalDoctors"]);
                    hospital.CityCode = Convert.ToInt32(reader["CityCode"]);
                    hospital.CountryCode = Convert.ToInt32(reader["CountryCode"]);
                    hospital.StateCode = Convert.ToInt32(reader["StateCode"]);

                    hospitalList.Add(hospital);
                }
            }
            return hospitalList;
        }
        public int InsertHospitalInfoMathod()
        {
            string connectionDetails = ConfigurationManager.ConnectionStrings["HMSConfig"].ConnectionString;

            int result = 0;


            using (SqlConnection connection = new SqlConnection(connectionDetails))
            {
                string dbcommand = @"insert into HospitalInfo values('" + @HospitalName + "','" + @PrimaryAddress +
                    "','" + @SecondaryAddress + "'," + @PinCode + "," + @Departments + "," + @TotalRoom +
                    "," + @FunctionalRoom + "," + @TotalDoctors + "," + @CityCode + "," + @CountryCode +
                    "," + @StateCode + ")";
                SqlCommand command = new SqlCommand(dbcommand, connection);
                connection.Open();

                result = command.ExecuteNonQuery();


            }
            return result;
        }
        
        public int DeleteHospitalInfo(int HospitalId)
        {
            string connectionDetails = ConfigurationManager.ConnectionStrings["HMSConfig"].ConnectionString;
            //string connectionDetails = @"data source = DESKTOP-8T682ON\SUMAN;database=Project;integrated security = true";

            int result = 0;

            using (SqlConnection connection = new SqlConnection(connectionDetails))
            {
                string dbcommand = "delete from HospitalInfo where HospitalID = (" + @HospitalId + ")";
                SqlCommand command = new SqlCommand(dbcommand, connection);
                connection.Open();
         
                 result = command.ExecuteNonQuery();
                 
            }
            return result;
        }
    }
}
