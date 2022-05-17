using Alphastellar.Models;
using System.Collections.Generic;

namespace Alphastellar.IBll
{
    public interface CountryInterface
    {
        List<Countries> AllCountries { get; }

         Countries GetCountryById(int countryId);
    }
}
