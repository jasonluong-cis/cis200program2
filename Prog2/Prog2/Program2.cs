// Grading ID: Z9467
// Program 2
// Due: 3/10/18
// Program that adds GUIS, dialog boxes, and validations that will make a Library GUI
// That takes out books, adds patrons, return books to their shelves, and make reports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class Program2Form : Form
    {
        private Library _lib; //Library
        DialogResult result; // Holds the results of the dialog box

        // Precondition: None
        // Postcondition: GUI is initialized and items are added 
        public Program2Form()
        {
            InitializeComponent();

            _lib = new Library(); //Creates Library
            //Adds Test Data
            _lib.AddLibraryBook("How to Read", "Book Inc.", 1990, 14, "000015683", "John Fisher");
            _lib.AddLibraryBook("How to do Things", "Publisher Inc.", 1995, 14, "000015615", "Bill Bo Baggings");
            _lib.AddLibraryJournal("New Math Theories", "Publisher Inc.", 1500, 18, "000012348", 1, 1, "Math Stuff", "Dukey");
            _lib.AddLibraryJournal("Revolutionary Sciencey Stuff", "Publisher Corp", 1904, 21, "000015846", 1, 3, "Science Stuff", "Dr. Grizzwald");
            _lib.AddLibraryMagazine("The Subscription", "Magazines Corp", 2050, 7, "000098761", 1, 2);
            _lib.AddLibraryMagazine("The Subscription", "Magazines Corp", 2051, 7, "000098762", 2, 9);
            _lib.AddLibraryMovie("The Revenge of Count Walter", "Koon Pictures Inc", 2024, 4, "000012845", 240,
                "Moose Meat the Third", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG13);
            _lib.AddLibraryMovie("Black Wasp", "Cynical Juice Box Inc", 2019, 5, "000098514", 180, "Mouse Fish, the Second",
                LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.R);
            _lib.AddLibraryMusic("Squash Those Mushrooms", "Music Inc", 2020, 6, "000063541", 51, "Stephan Smith",
                LibraryMediaItem.MediaType.VINYL, 15);
            _lib.AddLibraryMusic("Seven In and 4 out", "Loud & Right Company", 2025, 5, "000065482", 60, "7 Snails",
                LibraryMediaItem.MediaType.SACD, 16);
            _lib.AddPatron("Billy Bo", "12345");
            _lib.AddPatron("Milly Bo", "12346");
            _lib.AddPatron("Sally Bo", "12347");
            _lib.AddPatron("Silly Bo", "12348");
            _lib.AddPatron("Gilly Bo", "12349");
        }
        // Precondition: None
        // Postcondition: Shows a message box with the program info inside
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Grading ID: Z9467\nProgram 2\nDue: 3/10/2018");
        }
        // Precondition: None
        // Postcondition: Closes the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Precondition: None
        // Postcondition: Opens a dialog box that will add a patron's name and id
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm Patron = new PatronForm(); // variable that interacts with the patron form
            result = Patron.ShowDialog();
            string Name; // Name of the patron
            string ID; // The id of the patron

            if (result == DialogResult.OK)
            {
                Name = Patron.NameTextBox.Text;
                ID = Patron.IDTextBox.Text;
                _lib.AddPatron(Name, ID);
            }
        }
        // Precondition: None
        // Postcondition: Opens a dialog box that will add a book to the library
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm Book = new BookForm(); // variable that interacts with book form
            result = Book.ShowDialog();
            string Title; // the book's title
            string Publisher; // the book's author
            int LoanPeriod; // the loan period
            int Copyright; // the copyright year
            string CallNumber; // the call number in the library's system
            string Author; // the writer of the book

            if (result == DialogResult.OK)
            {
                Title = Book.titleTextbox.Text;
                Publisher = Book.publisherTextbox.Text;
                Copyright = int.Parse(Book.copyrightTextbox.Text);
                LoanPeriod = int.Parse(Book.loanPeriodTextbox.Text);
                CallNumber = Book.callNumberTextBox.Text;
                Author = Book.authorTextbox.Text;
                _lib.AddLibraryBook(Title, Publisher, Copyright, LoanPeriod, CallNumber, Author);
            }
        }
        // Precondition: None
        // Postcondition: Opens a dialog box that will check out an item in the library
        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckoutForm Checkout = new CheckoutForm(); // Variable that interacts with the checkout form
            foreach (var item in _lib.GetItemsList())
            {
                Checkout.itemCombobox.Items.Add($"{item.Title},{item.CallNumber}");
            }

            foreach(var patron in _lib.GetPatronsList())
            {
                Checkout.patronCombobox.Items.Add($"{patron.PatronName},{patron.PatronID}");
            }
            result = Checkout.ShowDialog();
            int itemindex;
            int patronindex; 
            if (result == DialogResult.OK)
            {
                itemindex = Checkout.itemCombobox.SelectedIndex;
                patronindex = Checkout.patronCombobox.SelectedIndex;
                _lib.CheckOut(itemindex, patronindex);
            }
        }
        // Precondition: None
        // Postcondition: Opens a Dialog box that will return an item to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnForm Return = new ReturnForm(); // Variable that interacts with the return form
            foreach (var item in _lib.GetItemsList())
            {
                Return.returnComboBox.Items.Add($"{item.Title},{item.CallNumber}");
            }
            int itemindex; //value that was selected from the form
            result = Return.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                itemindex = Return.returnComboBox.SelectedIndex;
                _lib.ReturnToShelf(itemindex);
            }
        }
        // Precondition: None
        // Postcondition: Writes a patron report in the textbox with their names and ids
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputTextbox.Clear();
            string results = ""; // Placeholder text
            var patronReport = new StringBuilder(); //stringbuilder that holds the count
            string NL = Environment.NewLine; // Adds a new line

            patronReport.Append($"Patron Report: {_lib.GetPatronCount()} Patrons{NL}");

            foreach(var patron in _lib.GetPatronsList())
            {
                results += $"Patron Name: {patron.PatronName} Patron ID:{patron.PatronID}{NL}";
            }
            OutputTextbox.Text = patronReport + results;
        }
        // Precondition: None
        // Postcondition: Writes an item report in the textbox with the titles and call number
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputTextbox.Clear();
            string results = ""; // Placeholder text
            string NL = Environment.NewLine; // Adds a new line
            var itemReport = new StringBuilder(); // stringbuilder that holds the count

            itemReport.Append($"Item Report: {_lib.GetItemCount()} items {NL}");

            foreach (var item in _lib.GetItemsList())
            {
                results += $"{item}{NL}{NL}" ;
            }
            OutputTextbox.Text = $"{itemReport}" +
                $"{results}{NL}";
    }
        // Precondition: None
        // Postcondition: Writes a report on the items that are checked out
        private void checkedOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputTextbox.Clear();
            string results = ""; //Placeholder
            var checkedoutReport = new StringBuilder(); //stringbuilder that holds count
            string NL = Environment.NewLine; // Adds new line
            checkedoutReport.Append($"Checked Out Report :{_lib.GetCheckedOutCount()} items {NL}");

            foreach (var item in _lib._items)
            {
                if (item.IsCheckedOut())
                {
                    results += $"{item}{NL}{NL}";
                }
            }
            OutputTextbox.Text = $"{checkedoutReport}" +
                $"{results}{NL}";
        }
    }
}
