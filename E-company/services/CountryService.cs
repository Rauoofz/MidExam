using E_company.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_company.services
{
    public class CountryService: ICountryService
    {
        CompanyContext context;
        public CountryService(CompanyContext _context)
        {
            context = _context;
        }
        public List<Country> LoadCountry()
        {
            List<Country> countries= context.countries.ToList();
            return countries;
        }
    }
}
