using Dapper;
using System;
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

        public List<Member> getAllMembersOrSearch(string searchText)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionString("SimpleLibrarySystem")))
            {
                return connection.Query<Member>("dbo.Member_GetAllMembersOrSearch @SearchText", new { SearchText = searchText }).ToList();
            }
        }

        public Book getBookByID(int bookID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionString("SimpleLibrarySystem")))
            {
                return connection.Query<Book>("dbo.Book_GetBookByID @id", new { id = bookID }).FirstOrDefault();
            }
        }

        public BorrowTransaction getBorrowedBookDetailsByBookID(int bookID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionString("SimpleLibrarySystem")))
            {
                return connection.Query<BorrowTransaction>("dbo.BorrowTransaction_GetDetailsByID @BookID, @MemberID", new { BookID= bookID, MemberID = "" }).FirstOrDefault();
            }
        }

        public List<BorrowTransaction> getBorrowedBookDetailsByMemberID(string memberID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionString("SimpleLibrarySystem")))
            {
                return connection.Query<BorrowTransaction>("dbo.BorrowTransaction_GetDetailsByID @BookID, @MemberID", new { BookID = 0, MemberID = memberID }).ToList();
            }
        }

        public Member getMemberByID(string memberID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionString("SimpleLibrarySystem")))
            {
                return connection.Query<Member>("dbo.Member_GetMemberByID @id", new { ID = memberID }).FirstOrDefault();
            }
        }

        public void insertUpdateDeleteBook(int ID, string bookNumber, string title, string author, int loanPeriod, bool availability, string status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionString("SimpleLibrarySystem")))
            {
                connection.Execute("dbo.Book_AddEditDeleteBook @id, @BookNumber, @Title, @Author, @LoanPeriod, @Availability, @Status", new { id = ID, BookNumber = bookNumber, Title = title, Author = author, LoanPeriod = loanPeriod, Availability = availability, Status = status });
            }
        }

        public void insertUpdateDeleteMember(string id, string name, string address, string phone, double fine, bool memberstatus, string status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionString("SimpleLibrarySystem")))
            {
                connection.Execute("dbo.Member_AddEditOrDeleteMember @ID, @Name, @Address, @Phone, @Fine, @Status", new { ID = id, Name = name, Address = address, Phone = phone, Fine = fine, Status = memberstatus Status = status });
            }
        }
    }
}
