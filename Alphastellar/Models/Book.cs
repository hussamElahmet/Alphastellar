using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alphastellar.Models
{
   
        public class pmBook
        {
            [Required(ErrorMessage = "Please enter book name")]
            public string BookName { set; get; }
            [Required(ErrorMessage = "Please enter check date")]
            [DataType(DataType.Date)]
            public DateTime From { get; set; }
            [Required(ErrorMessage = "Please enter return date")]
            [DataType(DataType.Date)]
            public DateTime To { get; set; }
            [Required(ErrorMessage = "Please select country")]
            public Countries Country { get; set; }
        
        }


        public class Book
        {
            [Key]
            public int Id { get; set; }
            public string Name { set; get; }
            public DateTime CheckDate { get; set; }
            public DateTime ReturnDate { get; set; }
            public decimal TotalPrice { get; set; }
            public int BuisnessDays { get; set; }
            public string Currency { get; set; }
            public DateTime CreateDate { set; get; }

        }
    }
