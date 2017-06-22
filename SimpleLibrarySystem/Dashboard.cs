using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        List<Member> members = new List<Member>();
        public Dashboard()
        {
            InitializeComponent();
            bookGroupBox.Visible = true;
            memberGroupBox.Visible = false;

            // Book fields validation
            this.bookNumberTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.bookTitleTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.bookAuthorTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);

            // Member fields validation
            this.memberNameTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.memberAddressTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.memberPhoneTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);

            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            populateAllData();
        }

        private void populateAllData()
        {
            books = db.getAllBooksOrSearch(bookNumberTextbox.Text);
            updateBookList();
            bookList.SelectedIndex = 0;

            members = db.getAllMembersOrSearch(memberIDTextbox.Text);
            updateMemberList();
            memberList.SelectedIndex = 0;
        }

        private void updateBookList()
        {
            bookList.DataSource = books;
            bookList.DisplayMember = "FullInfo";
            bookList.ValueMember = "id";
        }

        private void updateMemberList()
        {
            memberList.DataSource = members;
            memberList.DisplayMember = "Name";
            memberList.ValueMember = "ID";
        }

        private void updateBookDetails(Book details)
        {
            if (details != null)
            {
                bookNumberTextbox.Text = details.BookNumber;
                bookTitleTextbox.Text = details.Title;
                bookAuthorTextbox.Text = details.Author;

                bookLoanPeriodTextbox.Text = details.LoanPeriod.ToString();
                bookAvailabilityTextbox.Text = details.Availability == true ? "Available" : "Unavailable";

                if (!details.Availability)
                {
                    BorrowTransaction borrowDetails = new BorrowTransaction();
                    borrowDetails = db.getBorrowedBookDetailsByBookID(details.id);

                    bookBorrowerIDTextbox.Text = borrowDetails.MemberID;
                    bookBorrowDateTextbox.Text = borrowDetails.BorrowedDate.ToShortDateString();
                }
                else
                {
                    bookBorrowerIDTextbox.Text = "";
                    bookBorrowDateTextbox.Text = "";
                }
            }
        }

        private void updateMemberDetails(Member details)
        {
            if (details != null)
            {
                memberIDTextbox.Text = details.ID;
                memberNameTextbox.Text = details.Name;
                memberAddressTextbox.Text = details.Address;
                memberPhoneTextbox.Text = details.Phone;
                memberFineTextbox.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", details.Fine);

                List<BorrowTransaction> borrowDetails = new List<BorrowTransaction>();
                borrowDetails = db.getBorrowedBookDetailsByMemberID(details.ID);

                memberBorrowedBookDgv.DataSource = borrowDetails;
            }
        }

        private void bookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            disableBookFiels();

            if (bookList.SelectedIndex >= 0)
            {
                Book bookDetails = new Book();
                int bookID;
                int.TryParse(bookList.SelectedValue.ToString(), out bookID);

                bookDetails = db.getBookByID(bookID);
                updateBookDetails(bookDetails);
            }
        }
        private void memberList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberList.SelectedIndex >= 0)
            {
                Member memberDetails = new Member();

                memberDetails = db.getMemberByID(memberList.SelectedValue.ToString());
                updateMemberDetails(memberDetails);
            }
        }

        private void disableBookFiels()
        {
            bookNumberTextbox.Text = "";
            bookNumberTextbox.ReadOnly = true;

            bookTitleTextbox.Text = "";
            bookTitleTextbox.ReadOnly = true;

            bookAuthorTextbox.Text = "";
            bookAuthorTextbox.ReadOnly = true;

            bookAddOrUpdateButton.Visible = false;
        }

        private void enableBookFields()
        {
            bookSearchTextbox.Text = "";

            bookNumberTextbox.Text = "";
            bookNumberTextbox.ReadOnly = false;

            bookTitleTextbox.Text = "";
            bookTitleTextbox.ReadOnly = false;

            bookAuthorTextbox.Text = "";
            bookAuthorTextbox.ReadOnly = false;

            bookAvailabilityTextbox.Text = "Available";
            bookBorrowerIDTextbox.Text = "Available";

            bookLoanPeriodTextbox.Text = "14";

            bookAddOrUpdateButton.Visible = true;
        }

        private void bookSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            // Disable editing in the book details section.
            disableBookFiels();

            books = db.getAllBooksOrSearch(bookSearchTextbox.Text);
            updateBookList();
        }

        private void memberSearchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertNewBookButton_Click(object sender, EventArgs e)
        {
            // Enable editing in the book details section.
            enableBookFields();
            bookAddOrUpdateButton.Text = "Add";
        }

        private void editBookButton_Click(object sender, EventArgs e)
        {
            // Enable editing in the book details section.
            enableBookFields();
            bookAddOrUpdateButton.Text = "Edit";

            Book bookDetails = new Book();
            bookDetails = db.getBookByID(int.Parse(bookList.SelectedValue.ToString()));
            updateBookDetails(bookDetails);
        }

        private void bookTypeBookOrTextBookRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Loan period for a book is always set to 14 days
            if (((RadioButton)sender).Text == "Book")
            {
                bookLoanPeriodTextbox.Text = "14";
            }
            // Loan period for a Textbook is always set to 2 days
            else
            {
                bookLoanPeriodTextbox.Text = "2";
            }
        }

        private void bookAddOrUpdateButton_Click(object sender, EventArgs e)
        {
            bool availability = bookAvailabilityTextbox.Text == "Available" ? true : false;
            int loanPeriod = int.Parse(bookLoanPeriodTextbox.Text);
            string status = "";

            // Add new book
            if (bookAddOrUpdateButton.Text == "Add")
            {
                // Add new book
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    status = "Insert";
                    try
                    {
                        db.insertUpdateDeleteBook(0, bookNumberTextbox.Text, bookTitleTextbox.Text, bookAuthorTextbox.Text, loanPeriod, availability, null, null, status);

                        MessageBox.Show("New book has been successfully added to database.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);

                        // Update data in the book list
                        books = db.getAllBooksOrSearch(bookSearchTextbox.Text);
                        updateBookList();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Failed to add new book to database. Book number '" + bookNumberTextbox.Text + "' already exist.", "Insert Process Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    bookNumberTextbox.Text = "";
                    bookTitleTextbox.Text = "";
                    bookAuthorTextbox.Text = "";
                    bookLoanPeriodTextbox.Text = "14";
                    bookAvailabilityTextbox.Text = "Available";
                    bookBorrowerIDTextbox.Text = "";
                    bookBorrowDateTextbox.Text = "";
                }
            }
            // Edit existing book
            else
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    status = "Update";
                    try
                    {
                        string oldBook = bookTitleTextbox.Text;

                        db.insertUpdateDeleteBook(int.Parse(bookList.SelectedValue.ToString()), bookNumberTextbox.Text, bookTitleTextbox.Text, bookAuthorTextbox.Text, loanPeriod, availability, null, null, status);

                        MessageBox.Show("Book with title '" + oldBook + "' has been successfully updated.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);

                        // Update data in the book list
                        books = db.getAllBooksOrSearch(bookSearchTextbox.Text);
                        updateBookList();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Failed to update a book to database. Book number '" + bookNumberTextbox.Text + "' already exist.", "Update Process Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            bool availability = bookAvailabilityTextbox.Text == "Available" ? true : false;
            int loanPeriod = int.Parse(bookLoanPeriodTextbox.Text);
            string status = "Delete";
            string deletedBook = bookTitleTextbox.Text;

            if (availability)
            {
                try
                {
                    db.insertUpdateDeleteBook(int.Parse(bookList.SelectedValue.ToString()), bookNumberTextbox.Text, bookTitleTextbox.Text, bookAuthorTextbox.Text, loanPeriod, availability, null, null, status);

                    MessageBox.Show("Book with title '" + deletedBook + "' has been successfully removed from database.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Failed to delete the book from database. Book number '" + bookNumberTextbox.Text + "' still borrowed.", "Delete Process Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Update data in the book list
                books = db.getAllBooksOrSearch(bookSearchTextbox.Text);
                updateBookList();
            }
            else
                MessageBox.Show("Failed to delete the book from database. Book number '" + bookNumberTextbox.Text + "' still borrowed.", "Delete Process Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            // Validation for Book Number textbox
            TextBox textbox = (TextBox)sender;
            if (string.IsNullOrEmpty(textbox.Text))
            {
                e.Cancel = true;
                textbox.Focus();
                errorProvider.SetError(textbox, "This field must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textbox, null);
            }
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookGroupBox.Visible = true;
            memberGroupBox.Visible = false;
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookGroupBox.Visible = false;
            memberGroupBox.Visible = true;
        }
    }
}
