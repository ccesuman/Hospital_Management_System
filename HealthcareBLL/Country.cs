using HealthcareDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareBLL
{
    public class Country
    {
        public int CountryCode { get; set; }
        public string CountryName { get; set; }
        public List<Country> GetCountries()
        {
            List<Country> countryListbll = new List<Country>();
            CountryInfo countryinfo = new CountryInfo();
            List<CountryInfo> countryinfoList = countryinfo.GetCountryInfo();
            foreach (CountryInfo item in countryinfoList)
            {
                Country country = new Country();
                country.CountryCode = item.CountryCode;
                country.CountryName = item.CountryName;
                countryListbll.Add(country);
            }
            return countryListbll;
        }
    }
}
