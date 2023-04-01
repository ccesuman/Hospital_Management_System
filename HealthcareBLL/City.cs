using HealthcareDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareBLL
{
    public class City
    {
        public int CityCode { get; set; }
        public string CityName { get; set; }
        public int StateCode { get; set; }
        public List<City> GetCity()
        {
            List<City> cityListbll = new List<City>();
            CityInfo cityinfo = new CityInfo();
            List<CityInfo> cityinfoList = cityinfo.GetCityInfo();
            foreach (CityInfo item in cityinfoList)
            {
                City city = new City();
                city.CityCode = item.CityCode;
                city.CityName = item.CityName;
                city.StateCode = item.StateCode;
                cityListbll.Add(city);
            }
            return cityListbll;
        }
    }
}
