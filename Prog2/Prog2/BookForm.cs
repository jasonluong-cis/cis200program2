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
    public partial class BookForm : Form
    {
        int negative = 0; // Magic number that checks for negative numbers

        // Precondition: Clicked on the Book menu item
        // Postcondition: Opens and starts the Book Form
        public BookForm()
        {
            InitializeComponent();
        }

        // Precondition: Must be empty
        // Postcondition: Validates the title textbox and sends a warning if an exception is caught
        private void titleTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextbox.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(titleTextbox, "Enter a Title!");

                titleTextbox.SelectAll();
            }
        }

        // Precondition: Must be Empty
        // Postcondition: Validates the publisher textbox and sends a warning if an exception is caught
        private void publisherTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(publisherTextbox.Text))
            {
                e.Cancel = true;

                errorProvider2.SetError(publisherTextbox, "Enter a Publisher!");

                publisherTextbox.SelectAll();
            }
        }

        // Precondition: Must be empty, has letters in it, or has a negative number
        // Postcondition: Validates the copyright year textbox and sends a warning if an exception is caught
        private void copyrightTextbox_Validating(object sender, CancelEventArgs e)
        {
            int copyright;// number that comes out of try parse

            if (!int.TryParse(copyrightTextbox.Text, out copyright) ||
                Convert.ToInt32(copyrightTextbox.Text) < negative)
            {
                e.Cancel = true;

                errorProvider3.SetError(copyrightTextbox, "Enter a Copyright Year!");

                copyrightTextbox.SelectAll();
            }

        }

        // Precondition: Must be empty, has letters in it, or a negetive number
        // Postcondition: Validates the loan period textbox and sends a warning if an exception is caught
        private void loanPeriodTextbox_Validating(object sender, CancelEventArgs e)
        {
            int loanPeriod; // number that comes out of tryparse

            if (!int.TryParse(loanPeriodTextbox.Text, out loanPeriod) ||
                Convert.ToInt32(loanPeriodTextbox.Text) < negative)
            {
                e.Cancel = true;

                errorProvider4.SetError(loanPeriodTextbox, "Enter a Loan Period!");

                loanPeriodTextbox.SelectAll();
            }
        }

        // Precondition: Must be empty
        // Postcondition: Validates the callnumber textbox and sends a warning if an exception is caught
        private void callNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(callNumberTextBox.Text))
            {
                e.Cancel = true;

                errorProvider5.SetError(callNumberTextBox, "Enter a Call Number!");

                callNumberTextBox.SelectAll();
            }
        }

        // Precondition: Must be empty
        // Postcondition: Validates the auther textbox and sends a warning if an exception is caught
        private void authorTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(authorTextbox.Text))
            {
                e.Cancel = true;

                errorProvider6.SetError(authorTextbox, "Enter a Name!");

                authorTextbox.SelectAll();
            }
        }

        // Precondition: Must have been caught by validation event and fixed the issue
        // Postcondition: Gets rid of the warning 
        private void titleTextbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(titleTextbox, "");
        }

        // Precondition: Must have been caught by validation event and fixed the issue
        // Postcondition: Gets rid of the warning 
        private void publisherTextbox_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(publisherTextbox, "");
        }

        // Precondition: Must have been caught by validation event and fixed the issue
        // Postcondition: Gets rid of the warning 
        private void copyrightTextbox_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(copyrightTextbox, "");
        }

        // Precondition: Must have been caught by validation event and fixed the issue
        // Postcondition: Gets rid of the warning 
        private void loanPeriodTextbox_Validated(object sender, EventArgs e)
        {
            errorProvider4.SetError(loanPeriodTextbox, "");
        }

        // Precondition: Must have been caught by validation event and fixed the issue
        // Postcondition: Gets rid of the warning 
        private void callNumberTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider5.SetError(callNumberTextBox, "");
        }

        // Precondition: Must have been caught by validation event and fixed the issue
        // Postcondition: Gets rid of the warning 
        private void authorTextbox_Validated(object sender, EventArgs e)
        {
            errorProvider6.SetError(authorTextbox, "");
        }

        // Precondition: None
        // Postcondition: Cancels the book form dialog box
        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition: None
        // Postcondition: Validates the book form and sends a dialogresult.ok back to the main form and closes
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
