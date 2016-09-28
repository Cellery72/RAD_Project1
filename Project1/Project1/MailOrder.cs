using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace MailOrder
{
    public partial class MailOrder : Form
    {
        public MailOrder()
        {
            InitializeComponent();
        }

        // Event Handlers
        // --------------
        
        // Button Event Handlers
        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The form has been sent to the computer!","Print Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void NextButton_Click(object sender, EventArgs e)
        {            
            if (validValues())  // assert there's valid values in the controls
            {

            }
            else    // Values are stale, notify user, don't change to read only yet..
            {

            }
        }
        private void LanguageRBCheckedChanged(object sender, EventArgs e)
        {
            // Get an instance of the RB class that's calling the method
            RadioButton thisRB = (RadioButton)sender;

            // populate a string to handle the english or french variable 
            string language = (thisRB.Name == "FrenchRadioButton") ? "fr-CA" : "en-US";

            // Pass the language to the private function to change the language
            ChangeLanguage(language);
        }
        
        // Validation Event Handlers
        private void HoursWorkedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow numeric or the back button
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
        private void HoursWorkedTextBox_Validating(object sender, CancelEventArgs e)
        {
            // get local instance of the textbox and it's current value
            MaskedTextBox _HoursWorkedTB = (MaskedTextBox)sender;
            int currentValue = int.Parse(_HoursWorkedTB.Text);

            // assert value is valid
            if (currentValue > 160 || currentValue < 0)
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                _HoursWorkedTB.Select(0, _HoursWorkedTB.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.ErrorProvider.SetError(_HoursWorkedTB, "Value must be between 0-160");
            }
            else
                ErrorProvider.Clear();
        }
        private void EmployeeIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow numeric in Employee ID inputs
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void TotalMonthlySalesTextBox_Validating(object sender, CancelEventArgs e)
        {
            // get local instance
            TextBox _TotalMonthlySalesTB = (TextBox)sender;


        }





        // private methods 
        // ---------------

        /// <summary>
        /// Function changes the current language at runtime by passing in a language variable 
        /// </summary>
        /// <param name="lang"></param>
        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(MailOrder));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }
        /// <summary>
        /// Returns a value indicating whether the controls on the MailOrder form have valid values to be calculated
        /// </summary>
        /// <returns>bool</returns>
        private bool validValues()
        {
            bool rValue = false;
            // check hours worked isn't null or empty... validation will handle the value's between 0-160





            return rValue;
        }
    }
}
