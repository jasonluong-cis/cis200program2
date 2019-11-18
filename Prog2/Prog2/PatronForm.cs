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
    public partial class PatronForm : Form
    {
        // Precondition: None
        // Postcondition: Initialized Patron Form
        public PatronForm()
        {
            InitializeComponent();
        }

        // Precondition: Must have nothing in name textbox
        // Postcondition: Validates the Name Textbox and sends a warning
        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(NameTextBox, "Enter a Name!");

                NameTextBox.SelectAll();
            }
        }

        // Precondition: Must have been caught by validating event handler and fixed the issue
        // Postcondition: Gets rid of the error provider
        private void NameTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(NameTextBox, "");
        }

        // Precondition: Must have either letters or nothing in the textbox
        // Postcondition: Validates the id textbox and sends a warning
        private void IDTextBox_Validating(object sender, CancelEventArgs e)
        {
            int id; // number that comes out of tryparse
            int negative = 0; // negative magic number test
            if (!int.TryParse(IDTextBox.Text, out id) ||
                Convert.ToInt32(IDTextBox.Text) < negative)
            {
                e.Cancel = true;

                errorProvider2.SetError(IDTextBox, "Enter an ID!");

                IDTextBox.SelectAll();
            }
        }

        // Precondition: Must have been caught by the validating event handler and fixed the issue
        // Postcondition: Gets rid of the error provider
        private void IDTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(IDTextBox, "");
        }

        // Precondition: None
        // Postcondition: Validates all of the children and returns a dialogresult.ok back to the main form
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition: None
        // Postcondition: Canceled the form
        private void CancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
