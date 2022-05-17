using Alphastellar.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Alphastellar.IBll;

namespace Alphastellar.DataAccess
{
    public class CountryDAL : CountryInterface
    {
        private readonly Context _context;
        public CountryDAL(Context context)
        {
            _context = context;
        }

        //public IEnumerable<Countries> getCountriesList => _context.Countries;
        public IEnumerable<Countries> AllCountries => _context.Countries;


        public Countries GetCountryById(int countryId)
        {
            return _context.Countries.Include(h => h.CountryHolidays).FirstOrDefault(c => c.CountryId == countryId);
        }


    }
}
