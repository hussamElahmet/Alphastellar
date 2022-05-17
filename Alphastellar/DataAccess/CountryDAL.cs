using Alphastellar.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Alphastellar.IBll;
using static Alphastellar.Models.Book;
using Microsoft.AspNetCore.Mvc;

namespace Alphastellar.DataAccess
{
    public class CountryDAL : Ibook
    {
        private readonly Context _context;
        public CountryDAL(Context context)
        {
            _context = context;
        }

        //public IEnumerable<Countries> getCountriesList => _context.Countries;
        public List<Countries> AllCountries => _context.Countries.ToList();


        public List<Holidays> GetHolidaysById(int countryId)
        {
            return _context.Holidays.Where(x => x.CountryId == countryId).ToList();
        }
        public Book GetBook()
        {
            return _context.Book.OrderByDescending(x => x.CreateDate).First();
        }

        public string InsertBook(Book bookDetails)
        {
            Book book = new Book()
            {
                Name = bookDetails.Name,
                ReturnDate = bookDetails.ReturnDate,
                CheckDate = bookDetails.CheckDate,
                Currency = bookDetails.Currency,
                BuisnessDays = bookDetails.BuisnessDays,
                TotalPrice = bookDetails.TotalPrice,
                CreateDate = bookDetails.CreateDate
            };
            _context.Book.Add(book);
             _context.SaveChanges();
            return "Inserted Successfuly";
        }

    }
}
