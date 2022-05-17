using Alphastellar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alphastellar.IBll
{
    public interface CountryInterface
    {
        IEnumerable<Countries> AllCountries { get; }

         Countries GetCountryById(int countryId);
    }
}
