
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Alphastellar.Models;

namespace Alphastellar.DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
     
      
    }

}
