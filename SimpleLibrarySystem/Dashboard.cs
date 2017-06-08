using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLibrarySystem
{
    public partial class Dashboard :Form
    {
        DataAccess db = new DataAccess();
        List<Book> books = new List<Book>();
        public Dashboard()
        {
            InitializeComponent();
            books = db.getAllBooksOrSearch(bookTitleTextbox.Text);
            updateBookList();
            bookList.SelectedIndex = -1;
        }

        private void updateBookList()
        {
            bookList.DataSource = books;
            bookList.DisplayMember = "FullInfo";
            bookList.ValueMember = "id";
        }

        private void updateBookDetails(Book details)
        {
            if (details != null)
            {
                bookNumberTextbox.Text = details.BookNumber;
                bookTitleTextbox.Text = details.Title;
                bookAuthorTextbox.Text = details.Author;

                if(details.IsTextbook)
                {
                    bookTypeTextbookRadio.Checked = true;
                    bookTypeBookRadio.Checked = false;
                }
                else
                {
                    bookTypeBookRadio.Checked = true;
                    bookTypeTextbookRadio.Checked = false;
                }

                bookLoanPeriodTextbox.Text = details.LoanPeriod.ToString();
                bookAvailabilityTextbox.Text = details.Availability == true ? "Available" : "Unavailable";
                bookBorrowerIDTextbox.Text = details.BorrowerID == null ? "" : details.BorrowerID;
            }
        }

        private void bookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookList.SelectedIndex >= 0)
            {
                Book bookDetails = new Book();
                int bookID;
                int.TryParse(bookList.SelectedValue.ToString(), out bookID);

                bookDetails = db.getBookByID(bookID);
                updateBookDetails(bookDetails);
            }
        }

        private void bookSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            books = db.getAllBooksOrSearch(bookSearchTextbox.Text);
            updateBookList();
        }

        private void insertNewBookButton_Click(object sender, EventArgs e)
        {
            bookNumberTextbox.Text = String.Empty;
            bookNumberTextbox.ReadOnly = false;

            bookTitleTextbox.Text = String.Empty;
            bookTitleTextbox.ReadOnly = false;

            bookAuthorTextbox.Text = String.Empty;
            bookAuthorTextbox.ReadOnly = false;

            bookTypeBookRadio.AutoCheck = true;
            bookTypeTextbookRadio.AutoCheck = true;
            bookTypeBookRadio.Checked = true;
        }

        private void bookTypeBookOrTextBookRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Text == "Book")
            {
                bookLoanPeriodTextbox.Text = "14";
            }
            else
            {
                bookLoanPeriodTextbox.Text = "2";
            }
        }
    }
}
