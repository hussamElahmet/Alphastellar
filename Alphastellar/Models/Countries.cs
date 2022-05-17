using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alphastellar.Models
{
    public class Countries
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCurrency { get; set; }
        public List<Holidays> CountryHolidays { get; set; }
    }
}
