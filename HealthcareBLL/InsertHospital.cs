using HealthcareDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareBLL
{
    public  class InsertHospital
    {
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

        public int InsertHospitalMethod()
        {
            HospitalInfo hospitalinfo = new HospitalInfo();
            hospitalinfo.HospitalName = HospitalName;
            hospitalinfo.PrimaryAddress = PrimaryAddress;
            hospitalinfo.SecondaryAddress = SecondaryAddress;
            hospitalinfo.PinCode = PinCode;
            hospitalinfo.Departments = Departments;
            hospitalinfo.TotalRoom = TotalRoom;
            hospitalinfo.FunctionalRoom = FunctionalRoom;
            hospitalinfo.TotalDoctors = TotalDoctors;
            hospitalinfo.CityCode = CityCode;
            hospitalinfo.StateCode = StateCode;
            hospitalinfo.CountryCode = CountryCode;
            
            int result = hospitalinfo.InsertHospitalInfoMathod();

            return result;
        }
    }
}
