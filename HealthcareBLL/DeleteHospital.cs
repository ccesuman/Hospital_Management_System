using HealthcareDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareBLL
{
    public class DeleteHospital
    {
        public int DeleteHospitalMethod(int id)
        {
            int result = 0;
            HospitalInfo hospitalinfo = new HospitalInfo();
            result = hospitalinfo.DeleteHospitalInfo(id);
            return result;
        }
    }
}
