using Alphastellar.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alphastellar.IBll
{
    public interface Ibook
    {
        List<Countries> AllCountries { get; }
        List<Holidays> GetHolidaysById(int countryId);
        Book GetBook();
        string InsertBook(Book book);
    }
}
