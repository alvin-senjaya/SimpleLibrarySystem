using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SimpleLibrarySystem
{
    public class DataAccess
    {
        public List<Book> getAllBooksOrSearch(string searchText)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionString("SimpleLibrarySystem")))
            {
                return connection.Query<Book>("dbo.Book_GetAllBooksOrSearch @SearchText", new { SearchText = searchText }).ToList();
            }
        }

        public Book getBookByID(int bookID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionString("SimpleLibrarySystem")))
            {
                return connection.Query<Book>("dbo.Book_GetBookByID @id", new { id = bookID }).FirstOrDefault();
            }
        }

        public void insertUpdateDeleteBook(int ID, string bookNumber, string title, string author, int loanPeriod, bool availability, string borrowerID, string status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionString("SimpleLibrarySystem")))
            {
                connection.Execute("dbo.Book_AddEditDeleteBook @id, @BookNumber, @Title, @Author, @LoanPeriod, @Availability, @IsTextbook, @BorrowerID, @Status", new { id = ID, BookNumber = bookNumber, Title = title, Author = author, LoanPeriod = loanPeriod, Availability = availability, BorrowerID = borrowerID, Status = status });
            }
        }
    }
}
