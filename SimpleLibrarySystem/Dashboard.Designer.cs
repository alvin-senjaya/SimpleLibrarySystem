namespace SimpleLibrarySystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookList = new System.Windows.Forms.ListBox();
            this.bookGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.editBookButton = new System.Windows.Forms.Button();
            this.insertNewBookButton = new System.Windows.Forms.Button();
            this.bookSearchTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bookDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.bookAddOrUpdateButton = new System.Windows.Forms.Button();
            this.bookNumberTextbox = new System.Windows.Forms.TextBox();
            this.bookBorrowerIDTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bookAvailabilityTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bookLoanPeriodTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookAuthorTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookTitleTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.bookGroupBox.SuspendLayout();
            this.bookDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.memberToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(1722, 30);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // bookList
            // 
            this.bookList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bookList.FormattingEnabled = true;
            this.bookList.HorizontalScrollbar = true;
            this.bookList.ItemHeight = 25;
            this.bookList.Location = new System.Drawing.Point(7, 131);
            this.bookList.Name = "bookList";
            this.bookList.Size = new System.Drawing.Size(417, 479);
            this.bookList.TabIndex = 5;
            this.bookList.SelectedIndexChanged += new System.EventHandler(this.bookList_SelectedIndexChanged);
            // 
            // bookGroupBox
            // 
            this.bookGroupBox.Controls.Add(this.deleteBookButton);
            this.bookGroupBox.Controls.Add(this.editBookButton);
            this.bookGroupBox.Controls.Add(this.insertNewBookButton);
            this.bookGroupBox.Controls.Add(this.bookSearchTextbox);
            this.bookGroupBox.Controls.Add(this.label7);
            this.bookGroupBox.Controls.Add(this.bookDetailsGroupBox);
            this.bookGroupBox.Controls.Add(this.bookList);
            this.bookGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookGroupBox.Location = new System.Drawing.Point(0, 30);
            this.bookGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookGroupBox.Name = "bookGroupBox";
            this.bookGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookGroupBox.Size = new System.Drawing.Size(1722, 618);
            this.bookGroupBox.TabIndex = 0;
            this.bookGroupBox.TabStop = false;
            this.bookGroupBox.Text = "Book";
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Location = new System.Drawing.Point(186, 78);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(81, 47);
            this.deleteBookButton.TabIndex = 4;
            this.deleteBookButton.Text = "Delete";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // editBookButton
            // 
            this.editBookButton.Location = new System.Drawing.Point(99, 78);
            this.editBookButton.Name = "editBookButton";
            this.editBookButton.Size = new System.Drawing.Size(81, 47);
            this.editBookButton.TabIndex = 3;
            this.editBookButton.Text = "Edit";
            this.editBookButton.UseVisualStyleBackColor = true;
            this.editBookButton.Click += new System.EventHandler(this.editBookButton_Click);
            // 
            // insertNewBookButton
            // 
            this.insertNewBookButton.Location = new System.Drawing.Point(12, 78);
            this.insertNewBookButton.Name = "insertNewBookButton";
            this.insertNewBookButton.Size = new System.Drawing.Size(81, 47);
            this.insertNewBookButton.TabIndex = 2;
            this.insertNewBookButton.Text = "New";
            this.insertNewBookButton.UseVisualStyleBackColor = true;
            this.insertNewBookButton.Click += new System.EventHandler(this.insertNewBookButton_Click);
            // 
            // bookSearchTextbox
            // 
            this.bookSearchTextbox.Location = new System.Drawing.Point(99, 42);
            this.bookSearchTextbox.Name = "bookSearchTextbox";
            this.bookSearchTextbox.Size = new System.Drawing.Size(325, 30);
            this.bookSearchTextbox.TabIndex = 1;
            this.bookSearchTextbox.TextChanged += new System.EventHandler(this.bookSearchTextbox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search :";
            // 
            // bookDetailsGroupBox
            // 
            this.bookDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookDetailsGroupBox.Controls.Add(this.bookAddOrUpdateButton);
            this.bookDetailsGroupBox.Controls.Add(this.bookNumberTextbox);
            this.bookDetailsGroupBox.Controls.Add(this.bookBorrowerIDTextbox);
            this.bookDetailsGroupBox.Controls.Add(this.label8);
            this.bookDetailsGroupBox.Controls.Add(this.label6);
            this.bookDetailsGroupBox.Controls.Add(this.label5);
            this.bookDetailsGroupBox.Controls.Add(this.bookAvailabilityTextbox);
            this.bookDetailsGroupBox.Controls.Add(this.label4);
            this.bookDetailsGroupBox.Controls.Add(this.bookLoanPeriodTextbox);
            this.bookDetailsGroupBox.Controls.Add(this.label3);
            this.bookDetailsGroupBox.Controls.Add(this.bookAuthorTextbox);
            this.bookDetailsGroupBox.Controls.Add(this.label2);
            this.bookDetailsGroupBox.Controls.Add(this.bookTitleTextbox);
            this.bookDetailsGroupBox.Controls.Add(this.label1);
            this.bookDetailsGroupBox.Location = new System.Drawing.Point(430, 31);
            this.bookDetailsGroupBox.Name = "bookDetailsGroupBox";
            this.bookDetailsGroupBox.Size = new System.Drawing.Size(1280, 579);
            this.bookDetailsGroupBox.TabIndex = 6;
            this.bookDetailsGroupBox.TabStop = false;
            this.bookDetailsGroupBox.Text = "Book Details";
            // 
            // bookAddOrUpdateButton
            // 
            this.bookAddOrUpdateButton.Location = new System.Drawing.Point(163, 375);
            this.bookAddOrUpdateButton.Name = "bookAddOrUpdateButton";
            this.bookAddOrUpdateButton.Size = new System.Drawing.Size(81, 47);
            this.bookAddOrUpdateButton.TabIndex = 16;
            this.bookAddOrUpdateButton.Text = "Add";
            this.bookAddOrUpdateButton.UseVisualStyleBackColor = true;
            this.bookAddOrUpdateButton.Visible = false;
            this.bookAddOrUpdateButton.Click += new System.EventHandler(this.bookAddOrUpdateButton_Click);
            // 
            // bookNumberTextbox
            // 
            this.bookNumberTextbox.Location = new System.Drawing.Point(163, 39);
            this.bookNumberTextbox.Name = "bookNumberTextbox";
            this.bookNumberTextbox.ReadOnly = true;
            this.bookNumberTextbox.Size = new System.Drawing.Size(299, 30);
            this.bookNumberTextbox.TabIndex = 1;
            // 
            // bookBorrowerIDTextbox
            // 
            this.bookBorrowerIDTextbox.Location = new System.Drawing.Point(163, 339);
            this.bookBorrowerIDTextbox.Name = "bookBorrowerIDTextbox";
            this.bookBorrowerIDTextbox.ReadOnly = true;
            this.bookBorrowerIDTextbox.Size = new System.Drawing.Size(178, 30);
            this.bookBorrowerIDTextbox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Borrower :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Availability :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "days";
            // 
            // bookAvailabilityTextbox
            // 
            this.bookAvailabilityTextbox.Location = new System.Drawing.Point(163, 303);
            this.bookAvailabilityTextbox.Name = "bookAvailabilityTextbox";
            this.bookAvailabilityTextbox.ReadOnly = true;
            this.bookAvailabilityTextbox.Size = new System.Drawing.Size(126, 30);
            this.bookAvailabilityTextbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loan Period :";
            // 
            // bookLoanPeriodTextbox
            // 
            this.bookLoanPeriodTextbox.Location = new System.Drawing.Point(163, 267);
            this.bookLoanPeriodTextbox.Name = "bookLoanPeriodTextbox";
            this.bookLoanPeriodTextbox.ReadOnly = true;
            this.bookLoanPeriodTextbox.Size = new System.Drawing.Size(74, 30);
            this.bookLoanPeriodTextbox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author :";
            // 
            // bookAuthorTextbox
            // 
            this.bookAuthorTextbox.Location = new System.Drawing.Point(163, 173);
            this.bookAuthorTextbox.Multiline = true;
            this.bookAuthorTextbox.Name = "bookAuthorTextbox";
            this.bookAuthorTextbox.ReadOnly = true;
            this.bookAuthorTextbox.Size = new System.Drawing.Size(359, 88);
            this.bookAuthorTextbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title :";
            // 
            // bookTitleTextbox
            // 
            this.bookTitleTextbox.Location = new System.Drawing.Point(163, 75);
            this.bookTitleTextbox.Multiline = true;
            this.bookTitleTextbox.Name = "bookTitleTextbox";
            this.bookTitleTextbox.ReadOnly = true;
            this.bookTitleTextbox.Size = new System.Drawing.Size(359, 92);
            this.bookTitleTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Number :";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.memberToolStripMenuItem.Text = "Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1722, 648);
            this.Controls.Add(this.bookGroupBox);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.bookGroupBox.ResumeLayout(false);
            this.bookGroupBox.PerformLayout();
            this.bookDetailsGroupBox.ResumeLayout(false);
            this.bookDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ListBox bookList;
        private System.Windows.Forms.GroupBox bookGroupBox;
        private System.Windows.Forms.GroupBox bookDetailsGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookAuthorTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookTitleTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookAvailabilityTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookLoanPeriodTextbox;
        private System.Windows.Forms.TextBox bookSearchTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bookBorrowerIDTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.Button editBookButton;
        private System.Windows.Forms.Button insertNewBookButton;
        private System.Windows.Forms.TextBox bookNumberTextbox;
        private System.Windows.Forms.Button bookAddOrUpdateButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
    }
}

