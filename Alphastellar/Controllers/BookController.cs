using Alphastellar.DataProcess;
using Alphastellar.IBll;
using Alphastellar.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Alphastellar.Models.Book;
using static Alphastellar.Models.FormResult;


namespace Alphastellar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly Ibook InterfaceBook;
        public BookController(Ibook countryInterface)
        {
            InterfaceBook = countryInterface;
        }
        [HttpGet]
        public Book Get()
        {
            return InterfaceBook.GetBook(); ;
        }
        // POST api/<BookForm>
        [HttpPost]
        public void Post([FromForm] pmBook param )
        {
            param.Country = InterfaceBook.AllCountries.Where(x => x.CountryId == param.Country.CountryId).First();
            param.Country.CountryHolidays = InterfaceBook.GetHolidaysById(param.Country.CountryId);
            var BusinessDays = new CountryDPL().BusinessDaysGet(param);
            var TotalPrice = new CountryDPL().TotalPriceGet(BusinessDays);
            Book bookDetails = new Book();
            bookDetails.Name = param.BookName;
            bookDetails.ReturnDate = param.To;
            bookDetails.CheckDate = param.From;
            bookDetails.Currency = param.Country.CountryCurrency;
            bookDetails.BuisnessDays = BusinessDays;
            bookDetails.TotalPrice = TotalPrice;
            bookDetails.CreateDate = System.DateTime.Now;
            InterfaceBook.InsertBook(bookDetails);

        }
    }
}
