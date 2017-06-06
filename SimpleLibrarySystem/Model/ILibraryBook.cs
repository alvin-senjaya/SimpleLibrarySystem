using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    public interface ILibraryBook
    {
        // returns the book number for this LibraryBook
        String getBookNumber();

        // returns the borrower ID for this LibraryBook
        String getBorrowerID();

        // returns whether this LibraryBook is currently available or not
        bool isAvailable();

        // attempts to borrow this LibraryBook for the specified member
        void borrowBook(ILibraryMember member);

        // returns this LibraryBook
        void returnBook();

        // prints the details of this LibraryBook
        void print();
    }
}
