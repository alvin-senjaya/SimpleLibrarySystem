using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem.Model
{
    public class Book : ILibraryBook
    {
        public void borrowBook(ILibraryMember member)
        {
            throw new NotImplementedException();
        }

        public string getBookNumber()
        {
            throw new NotImplementedException();
        }

        public string getBorrowerID()
        {
            throw new NotImplementedException();
        }

        public bool isAvailable()
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            throw new NotImplementedException();
        }

        public void returnBook()
        {
            throw new NotImplementedException();
        }
    }
}
