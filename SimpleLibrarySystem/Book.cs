using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    public class Book
    {
        public int id { get; set; }
        public string BookNumber { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int LoanPeriod { get; set; }
        public bool Availability { get; set; }
        public string BorrowerID { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{ Title } ({ Author })";
            }
        }
    }
}
