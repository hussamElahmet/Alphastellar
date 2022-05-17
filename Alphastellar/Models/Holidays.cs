using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alphastellar.Models
{
    public class Holidays
    {
        [Key]
        public int HolidayId { get; set; }
        public string HolidayName { get; set; }
        public DateTime HolidayDate { get; set; }
        public int CountryId { get; set; }
        public Countries Country { get; set; }
    }
}
