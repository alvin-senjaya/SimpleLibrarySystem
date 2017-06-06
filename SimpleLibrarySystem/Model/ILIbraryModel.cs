using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem.Model
{
    public interface ILIbraryModel
    {// adds a new Member
        public bool addMember();

        // retrieves the Member with the specified member Id
        public ILibraryMember getMember(String memberID);

        // displays details for all Members in the system
        public void displayAllMembers();

        // retrieves the Book with the specified bookNumber 
        public ILibraryBook getBook(String bookNumber);

        // attempts to borrow the Book for the specifried Member
        public void borrowBook(String memberID, String bookNumber);

        // attempts to return the Book for the specified Member
        public void returnBook(String memberID,
                               String bookNumber, int daysBorrowed);

        // displays details for all Books currently in the system
        public void displayAllBooks();

        // loads book data from the books.txt file, reconstructs the
        // corresponding set of Book objects and stores them in the collection
        public void loadAllBooks();

        // loads book data from the Member data file, reconstructs the
        // corresponding set of Member objects and stores them in the collection
        public void loadAllMembers();

        // extracts and writes details for all Book objects in the system
        // out to the books.txt file
        public void saveAllBooks();

        // extracts and writes details for all Member objects in the system
        // out to the Member data file
        public void saveAllMembers();
    }
}
