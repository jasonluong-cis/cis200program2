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
    public partial class CheckoutForm : Form
    {
        int empty = -1; //Magic number for index not being changed

        // Precondition: Clicked on Checkout in the main form
        // Postcondition: Opens and initialized the Checkout Form
        public CheckoutForm()
        {
            InitializeComponent();
        }

        // Precondition: Must be empty
        // Postcondition: Sends a warning if the index hasn't been changed
        private void itemCombobox_Validating(object sender, CancelEventArgs e)
        {
            if (itemCombobox.SelectedIndex == empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(itemCombobox, "Select an item");
                itemCombobox.SelectAll();
            }
        }

        // Precondition: Must have been caught by the validation event and fixed the issue
        // Postcondition: Gets rid of the warning
        private void itemCombobox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(itemCombobox, "");
        }

        // Precondition: Must be empty
        // Postcondition: Sends a warning if the index hasn't been changed
        private void patronCombobox_Validating(object sender, CancelEventArgs e)
        {
            if (patronCombobox.SelectedIndex == empty)
            {
                e.Cancel = true;
                errorProvider2.SetError(patronCombobox, "Select a Patron");
                patronCombobox.SelectAll();
            }
        }

        // Precondition: Must have been caught by the validation event and fixed the issue
        // Postcondition: Gets rid of the warning 
        private void patronCombobox_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(patronCombobox, "");
        }

        // Precondition: None
        // Postcondition: Validates the children and sends a dialogresult.ok back to the main form and closes 
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition: None
        // Postcondition: Cancels the Checkout form and closes
        private void CancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
