using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    public class DataAccess
    {
        public List<Book> getAllBooksOrSearch(string searchText)
        {
            using (IDbConnection connection =  new System.Data.SqlClient.SqlConnection(Helper.ConnectionString("SimpleLibrarySystem")))
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
    }
}
