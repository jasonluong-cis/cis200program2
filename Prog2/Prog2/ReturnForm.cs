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
    public partial class ReturnForm : Form
    {
        // Precondition: None
        // Postcondition: Opens and starts the Return form
        public ReturnForm()
        {
            InitializeComponent();
        }

        int empty = -1; // Magic number that tests if index hasn't changed

        // Precondition: None
        // Postcondition: Validates the children in the form and sends a dialogresult.ok and closes
        private void oKButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren());
            this.DialogResult = DialogResult.OK;
        }

        // Precondition: None
        // Postcondition: Cancels the form and closes
        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition: Has to be empty
        // Postcondition: Validates the combo box and sends a warning if it is empty
        private void returnComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (returnComboBox.SelectedIndex == empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(returnComboBox, "Select an item");
                returnComboBox.SelectAll();
            }
        }

        // Precondition: Has to been caught by the validation event and fixed
        // Postcondition: Gets rid of the error message
        private void returnComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(returnComboBox, "");
        }
    }
}
