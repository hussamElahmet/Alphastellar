using Alphastellar.DataAccess;
using Alphastellar.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using static Alphastellar.Models.Book;

namespace Alphastellar.DataProcess
{
    public class CountryDPL 
    {
        
        // penalty function 
        static decimal priceOfPenalty = 5;
        private readonly int PenaltyDaysLimit = 10;

        public decimal TotalPriceGet(int days)
        {
            decimal TotalPrice = days > PenaltyDaysLimit ? (days - PenaltyDaysLimit) * priceOfPenalty : 0;
            return TotalPrice;
        }
        // buisness days function 
        public int BusinessDaysGet(pmBook param)
        {
            int TotalBusinessDays = 0;
            // get holidays date array to exclude it from total days 
            var holidays = param.Country.CountryHolidays.Select(s => s.HolidayDate);
            //deffirence between from  and to date 
            for (var date = param.From; date <= param.To; date = date.AddDays(1))
            {
                if(param.Country.CountryId==1)
                {
                    if (date.DayOfWeek != DayOfWeek.Saturday
                  && date.DayOfWeek != DayOfWeek.Sunday
                  && !holidays.Contains(date))
                        TotalBusinessDays++;

                }else if(param.Country.CountryId==2)
                {
                    if (date.DayOfWeek != DayOfWeek.Friday
                       && date.DayOfWeek != DayOfWeek.Saturday
                       && !holidays.Contains(date))
                        TotalBusinessDays++;
                }
            }
            return TotalBusinessDays;
        }


        

    }
}
