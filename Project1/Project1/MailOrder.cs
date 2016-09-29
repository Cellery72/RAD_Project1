/*
 *  Application:   Mail Order Form
 *       Author:   Justin Ellery
 *         Date:   September 28th 2016
 *  Description:   The Mail Order Form handles calculating the Sales Bonus of multiple employees in an organization
 *                 based on the amount of hours they worked in relation to the monthly sales total.
 */

using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace MailOrder
{
    public partial class MailOrder : Form
    {
        private bool _BoolFirstEntry = true;    // represents whether or not it's the first employee we're entering
        public MailOrder()
        {
            InitializeComponent();
        }

        // Event Handlers
        // --------------
        
        // Button Event Handlers
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double output = CalculateValues();          // calculate values and store in double
            if (output != -1)                           // assert we didn't get garbage value
            {
                SalesBonusTextBox.Text = output.ToString("C"); // populate textbox
                TotalMonthlySalesTextBox.ReadOnly = true;   // set to read only after calculating
                _BoolFirstEntry = false;
            }
            else
                return;

        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Display a messagebox to show the form has been sent to the printer
            MessageBox.Show("The form has been sent to the computer!","Print Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void NextButton_Click(object sender, EventArgs e)
        {            
            if (_BoolFirstEntry)    // first time entering values, still haven't calculated once..
            {
                ClearValues();  // clear all values + Total Monthly Sales
                TotalMonthlySalesTextBox.Clear();
            }
            else
            {
                // clear the values neccessary 
                ClearValues();
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
            int currentValue = 0;
            if (!String.IsNullOrEmpty(_HoursWorkedTB.Text))
                currentValue = int.Parse(_HoursWorkedTB.Text);

            // assert value is valid
            if (currentValue > 160 || currentValue < 0)
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                _HoursWorkedTB.Select(0, _HoursWorkedTB.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                ErrorProvider.SetError(_HoursWorkedTB, "Must be a valid value between 0-160");
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
            try
            {
                double currentValue = 0;
                if (!String.IsNullOrEmpty(_TotalMonthlySalesTB.Text))
                    currentValue = double.Parse(_TotalMonthlySalesTB.Text);
                ErrorProvider.Clear();
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex);
                e.Cancel = true;
                _TotalMonthlySalesTB.Select(0, _TotalMonthlySalesTB.Text.Length);
                ErrorProvider.SetError(_TotalMonthlySalesTB, "Must be a valid numeric value");
            }
        }
        

        // private methods 
        // ---------------

        /// <summary>
        /// Function changes the current language at runtime by passing in a language variable. 
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
        /// Calculates the Sales Bonus value based on the textbox values.
        /// </summary>
        /// <returns></returns>
        private double CalculateValues()
        {
            double returnValue = -1;

            try
            {
                // Parse the textboxes to doubles, perform calculations.
                double hoursValue = (double.Parse(HoursWorkedTextBox.Text) / 160);
                double monthSalesValue = (double.Parse(TotalMonthlySalesTextBox.Text) * 0.02);
                returnValue = (hoursValue * monthSalesValue);
                return returnValue;
            }
            catch(Exception ex)
            {
                // log the error and response with -1;
                Console.WriteLine(ex);
                return returnValue;
            }

        }
        
        /// <summary>
        /// Clear all the values in the appropriate textboxes.
        /// </summary>
        private void ClearValues()
        {
            if (!_BoolFirstEntry)
                NextButton.Text = "Next";
            EmployeeNameTextBox.Clear();
            EmployeeIDTextBox.Clear();
            HoursWorkedTextBox.Clear();
            SalesBonusTextBox.Clear();

        }
    }
}
