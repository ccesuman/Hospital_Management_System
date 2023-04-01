using HealthcareDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareBLL
{
    /// <summary>
    /// hera copy the data from HospitalInfo class which have data of HospitalInfo table
    /// </summary>
    public class Hospital
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

        public List<Hospital> ViewHospitalInfo()
        {
            List<Hospital> hospitallist = new List<Hospital>();
            Hospital hospital = new Hospital();
            HospitalInfo hospitalinfo = new HospitalInfo();
            List<HospitalInfo> list = hospitalinfo.GetHospitalInfo();
            foreach (HospitalInfo s in list)
            {
                hospital.HospitalId = s.HospitalId;
                hospital.HospitalName = s.HospitalName;
                hospital.PrimaryAddress = s.PrimaryAddress;
                hospital.SecondaryAddress = s.SecondaryAddress;
                hospital.PinCode = s.PinCode;
                hospital.Departments = s.Departments;
                hospital.TotalRoom = s.TotalRoom;
                hospital.FunctionalRoom = s.FunctionalRoom;
                hospital.TotalDoctors = s.TotalDoctors;
                hospital.CityCode = s.CityCode;
                hospital.StateCode = s.StateCode;
                hospital.CountryCode = s.CountryCode;
                hospitallist.Add(hospital);
            }
            return hospitallist;
        }
    }
}
