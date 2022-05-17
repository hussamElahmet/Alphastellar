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
        public int BusinessDaysGet(pmBook inputModel)
        {
            int TotalBusinessDays = 0;

            var holidays = inputModel.Country.CountryHolidays.Select(s => s.HolidayDate);

            var dayDifference = (int)inputModel.To.Subtract(inputModel.From).TotalDays;

            for (var date = inputModel.From; date <= inputModel.To; date = date.AddDays(1))
            {
                if(inputModel.Country.CountryId==1)
                {
                    if (date.DayOfWeek != DayOfWeek.Saturday
                  && date.DayOfWeek != DayOfWeek.Sunday
                  && !holidays.Contains(date))
                        TotalBusinessDays++;

                }else if(inputModel.Country.CountryId==2)
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
