using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    public class BorrowTransaction
    {
        public string MemberID { get; set; }
        public int BookID { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool isReturned { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
