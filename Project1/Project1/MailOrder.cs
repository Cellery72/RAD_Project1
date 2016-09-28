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
        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }
        private void PrintButton_Click(object sender, EventArgs e)
        {

        }
        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void HoursWorkedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
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
    }
}
