using Alphastellar.Models;
using System.Collections.Generic;

namespace Alphastellar.IBll
{
    public interface CountryInterface
    {
        IEnumerable<Countries> AllCountries { get; }

         Countries GetCountryById(int countryId);
    }
}
