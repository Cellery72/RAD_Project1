namespace MailOrder
{
    partial class MailOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailOrder));
            this.LanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.TotalMonthlySalesTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.TotalMonthlySalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.HoursWorkedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LanguageGroupBox
            // 
            resources.ApplyResources(this.LanguageGroupBox, "LanguageGroupBox");
            this.LanguageGroupBox.Controls.Add(this.FrenchRadioButton);
            this.LanguageGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguageGroupBox.Name = "LanguageGroupBox";
            this.LanguageGroupBox.TabStop = false;
            // 
            // FrenchRadioButton
            // 
            resources.ApplyResources(this.FrenchRadioButton, "FrenchRadioButton");
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.TabStop = true;
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this.LanguageRBCheckedChanged);
            // 
            // EnglishRadioButton
            // 
            resources.ApplyResources(this.EnglishRadioButton, "EnglishRadioButton");
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.LanguageRBCheckedChanged);
            // 
            // EmployeeNameTextBox
            // 
            resources.ApplyResources(this.EmployeeNameTextBox, "EmployeeNameTextBox");
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            // 
            // EmployeeIDTextBox
            // 
            resources.ApplyResources(this.EmployeeIDTextBox, "EmployeeIDTextBox");
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            // 
            // TotalMonthlySalesTextBox
            // 
            resources.ApplyResources(this.TotalMonthlySalesTextBox, "TotalMonthlySalesTextBox");
            this.TotalMonthlySalesTextBox.Name = "TotalMonthlySalesTextBox";
            // 
            // SalesBonusTextBox
            // 
            resources.ApplyResources(this.SalesBonusTextBox, "SalesBonusTextBox");
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            // 
            // EmployeeNameLabel
            // 
            resources.ApplyResources(this.EmployeeNameLabel, "EmployeeNameLabel");
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            // 
            // EmployeeIDLabel
            // 
            resources.ApplyResources(this.EmployeeIDLabel, "EmployeeIDLabel");
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            // 
            // HoursWorkedLabel
            // 
            resources.ApplyResources(this.HoursWorkedLabel, "HoursWorkedLabel");
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            // 
            // TotalMonthlySalesLabel
            // 
            resources.ApplyResources(this.TotalMonthlySalesLabel, "TotalMonthlySalesLabel");
            this.TotalMonthlySalesLabel.Name = "TotalMonthlySalesLabel";
            // 
            // SalesBonusLabel
            // 
            resources.ApplyResources(this.SalesBonusLabel, "SalesBonusLabel");
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            // 
            // CalculateButton
            // 
            resources.ApplyResources(this.CalculateButton, "CalculateButton");
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // PrintButton
            // 
            resources.ApplyResources(this.PrintButton, "PrintButton");
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // NextButton
            // 
            resources.ApplyResources(this.NextButton, "NextButton");
            this.NextButton.Name = "NextButton";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // LogoPictureBox
            // 
            resources.ApplyResources(this.LogoPictureBox, "LogoPictureBox");
            this.LogoPictureBox.Image = global::Project1.Properties.Resources.rad;
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.TabStop = false;
            // 
            // HoursWorkedTextBox
            // 
            resources.ApplyResources(this.HoursWorkedTextBox, "HoursWorkedTextBox");
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            // 
            // MailOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalMonthlySalesLabel);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.TotalMonthlySalesTextBox);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.LanguageGroupBox);
            this.Name = "MailOrder";
            this.LanguageGroupBox.ResumeLayout(false);
            this.LanguageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LanguageGroupBox;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox TotalMonthlySalesTextBox;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.Label TotalMonthlySalesLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.MaskedTextBox HoursWorkedTextBox;
    }
}

