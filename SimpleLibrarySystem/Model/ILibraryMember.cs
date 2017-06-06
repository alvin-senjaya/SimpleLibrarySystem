using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    public interface ILibraryMember
    {
        // returns the id of the LibraryMember
        String getMemberID();

        // attempts to borrow the specified Book for the LibraryMember 
        void borrowBook(ILibraryBook b);

        // attempts to return the Book with the specificed book number for the LibraryMember
        void returnBook(String bookNumber, int days);

        // returns the collection of Books that the member currently had borrowed
        List<ILibraryBook> getBorrowedBooks();

        // prints details for this LibraryMember to screen
        void print();
    }
}
