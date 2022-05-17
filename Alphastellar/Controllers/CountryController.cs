using Alphastellar.DataAccess;
using Alphastellar.DataProcess;
using Alphastellar.IBll;
using Alphastellar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Alphastellar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly Ibook _countryRepository;

        public CountryController(Ibook countryInterface)
        {
            _countryRepository = countryInterface;
        }
        // GET: api/<Country>
        [HttpGet]
        public List<Countries> Get()
        {
            List<Countries> countries = _countryRepository.AllCountries.ToList();
            return countries;
        }
    }
}
