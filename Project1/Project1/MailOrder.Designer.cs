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
            this.components = new System.ComponentModel.Container();
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
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LanguageGroupBox
            // 
            resources.ApplyResources(this.LanguageGroupBox, "LanguageGroupBox");
            this.LanguageGroupBox.Controls.Add(this.FrenchRadioButton);
            this.LanguageGroupBox.Controls.Add(this.EnglishRadioButton);
            this.ErrorProvider.SetError(this.LanguageGroupBox, resources.GetString("LanguageGroupBox.Error"));
            this.ErrorProvider.SetIconAlignment(this.LanguageGroupBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LanguageGroupBox.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.LanguageGroupBox, ((int)(resources.GetObject("LanguageGroupBox.IconPadding"))));
            this.LanguageGroupBox.Name = "LanguageGroupBox";
            this.LanguageGroupBox.TabStop = false;
            // 
            // FrenchRadioButton
            // 
            resources.ApplyResources(this.FrenchRadioButton, "FrenchRadioButton");
            this.ErrorProvider.SetError(this.FrenchRadioButton, resources.GetString("FrenchRadioButton.Error"));
            this.ErrorProvider.SetIconAlignment(this.FrenchRadioButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("FrenchRadioButton.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.FrenchRadioButton, ((int)(resources.GetObject("FrenchRadioButton.IconPadding"))));
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.TabStop = true;
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this.LanguageRBCheckedChanged);
            // 
            // EnglishRadioButton
            // 
            resources.ApplyResources(this.EnglishRadioButton, "EnglishRadioButton");
            this.EnglishRadioButton.Checked = true;
            this.ErrorProvider.SetError(this.EnglishRadioButton, resources.GetString("EnglishRadioButton.Error"));
            this.ErrorProvider.SetIconAlignment(this.EnglishRadioButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("EnglishRadioButton.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.EnglishRadioButton, ((int)(resources.GetObject("EnglishRadioButton.IconPadding"))));
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.LanguageRBCheckedChanged);
            // 
            // EmployeeNameTextBox
            // 
            resources.ApplyResources(this.EmployeeNameTextBox, "EmployeeNameTextBox");
            this.ErrorProvider.SetError(this.EmployeeNameTextBox, resources.GetString("EmployeeNameTextBox.Error"));
            this.ErrorProvider.SetIconAlignment(this.EmployeeNameTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("EmployeeNameTextBox.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.EmployeeNameTextBox, ((int)(resources.GetObject("EmployeeNameTextBox.IconPadding"))));
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.ShortcutsEnabled = false;
            // 
            // EmployeeIDTextBox
            // 
            resources.ApplyResources(this.EmployeeIDTextBox, "EmployeeIDTextBox");
            this.ErrorProvider.SetError(this.EmployeeIDTextBox, resources.GetString("EmployeeIDTextBox.Error"));
            this.ErrorProvider.SetIconAlignment(this.EmployeeIDTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("EmployeeIDTextBox.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.EmployeeIDTextBox, ((int)(resources.GetObject("EmployeeIDTextBox.IconPadding"))));
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.ShortcutsEnabled = false;
            this.EmployeeIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeIDTextBox_KeyPress);
            // 
            // TotalMonthlySalesTextBox
            // 
            resources.ApplyResources(this.TotalMonthlySalesTextBox, "TotalMonthlySalesTextBox");
            this.ErrorProvider.SetError(this.TotalMonthlySalesTextBox, resources.GetString("TotalMonthlySalesTextBox.Error"));
            this.ErrorProvider.SetIconAlignment(this.TotalMonthlySalesTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TotalMonthlySalesTextBox.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.TotalMonthlySalesTextBox, ((int)(resources.GetObject("TotalMonthlySalesTextBox.IconPadding"))));
            this.TotalMonthlySalesTextBox.Name = "TotalMonthlySalesTextBox";
            this.TotalMonthlySalesTextBox.ShortcutsEnabled = false;
            this.TotalMonthlySalesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TotalMonthlySalesTextBox_Validating);
            // 
            // SalesBonusTextBox
            // 
            resources.ApplyResources(this.SalesBonusTextBox, "SalesBonusTextBox");
            this.ErrorProvider.SetError(this.SalesBonusTextBox, resources.GetString("SalesBonusTextBox.Error"));
            this.ErrorProvider.SetIconAlignment(this.SalesBonusTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("SalesBonusTextBox.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.SalesBonusTextBox, ((int)(resources.GetObject("SalesBonusTextBox.IconPadding"))));
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.ShortcutsEnabled = false;
            // 
            // EmployeeNameLabel
            // 
            resources.ApplyResources(this.EmployeeNameLabel, "EmployeeNameLabel");
            this.ErrorProvider.SetError(this.EmployeeNameLabel, resources.GetString("EmployeeNameLabel.Error"));
            this.ErrorProvider.SetIconAlignment(this.EmployeeNameLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("EmployeeNameLabel.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.EmployeeNameLabel, ((int)(resources.GetObject("EmployeeNameLabel.IconPadding"))));
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            // 
            // EmployeeIDLabel
            // 
            resources.ApplyResources(this.EmployeeIDLabel, "EmployeeIDLabel");
            this.ErrorProvider.SetError(this.EmployeeIDLabel, resources.GetString("EmployeeIDLabel.Error"));
            this.ErrorProvider.SetIconAlignment(this.EmployeeIDLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("EmployeeIDLabel.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.EmployeeIDLabel, ((int)(resources.GetObject("EmployeeIDLabel.IconPadding"))));
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            // 
            // HoursWorkedLabel
            // 
            resources.ApplyResources(this.HoursWorkedLabel, "HoursWorkedLabel");
            this.ErrorProvider.SetError(this.HoursWorkedLabel, resources.GetString("HoursWorkedLabel.Error"));
            this.ErrorProvider.SetIconAlignment(this.HoursWorkedLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("HoursWorkedLabel.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.HoursWorkedLabel, ((int)(resources.GetObject("HoursWorkedLabel.IconPadding"))));
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            // 
            // TotalMonthlySalesLabel
            // 
            resources.ApplyResources(this.TotalMonthlySalesLabel, "TotalMonthlySalesLabel");
            this.ErrorProvider.SetError(this.TotalMonthlySalesLabel, resources.GetString("TotalMonthlySalesLabel.Error"));
            this.ErrorProvider.SetIconAlignment(this.TotalMonthlySalesLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TotalMonthlySalesLabel.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.TotalMonthlySalesLabel, ((int)(resources.GetObject("TotalMonthlySalesLabel.IconPadding"))));
            this.TotalMonthlySalesLabel.Name = "TotalMonthlySalesLabel";
            // 
            // SalesBonusLabel
            // 
            resources.ApplyResources(this.SalesBonusLabel, "SalesBonusLabel");
            this.ErrorProvider.SetError(this.SalesBonusLabel, resources.GetString("SalesBonusLabel.Error"));
            this.ErrorProvider.SetIconAlignment(this.SalesBonusLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("SalesBonusLabel.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.SalesBonusLabel, ((int)(resources.GetObject("SalesBonusLabel.IconPadding"))));
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            // 
            // CalculateButton
            // 
            resources.ApplyResources(this.CalculateButton, "CalculateButton");
            this.ErrorProvider.SetError(this.CalculateButton, resources.GetString("CalculateButton.Error"));
            this.ErrorProvider.SetIconAlignment(this.CalculateButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("CalculateButton.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.CalculateButton, ((int)(resources.GetObject("CalculateButton.IconPadding"))));
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // PrintButton
            // 
            resources.ApplyResources(this.PrintButton, "PrintButton");
            this.ErrorProvider.SetError(this.PrintButton, resources.GetString("PrintButton.Error"));
            this.ErrorProvider.SetIconAlignment(this.PrintButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("PrintButton.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.PrintButton, ((int)(resources.GetObject("PrintButton.IconPadding"))));
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // NextButton
            // 
            resources.ApplyResources(this.NextButton, "NextButton");
            this.ErrorProvider.SetError(this.NextButton, resources.GetString("NextButton.Error"));
            this.ErrorProvider.SetIconAlignment(this.NextButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("NextButton.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.NextButton, ((int)(resources.GetObject("NextButton.IconPadding"))));
            this.NextButton.Name = "NextButton";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // LogoPictureBox
            // 
            resources.ApplyResources(this.LogoPictureBox, "LogoPictureBox");
            this.ErrorProvider.SetError(this.LogoPictureBox, resources.GetString("LogoPictureBox.Error"));
            this.ErrorProvider.SetIconAlignment(this.LogoPictureBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LogoPictureBox.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.LogoPictureBox, ((int)(resources.GetObject("LogoPictureBox.IconPadding"))));
            this.LogoPictureBox.Image = global::Project1.Properties.Resources.rad;
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.TabStop = false;
            // 
            // HoursWorkedTextBox
            // 
            resources.ApplyResources(this.HoursWorkedTextBox, "HoursWorkedTextBox");
            this.ErrorProvider.SetError(this.HoursWorkedTextBox, resources.GetString("HoursWorkedTextBox.Error"));
            this.ErrorProvider.SetIconAlignment(this.HoursWorkedTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("HoursWorkedTextBox.IconAlignment"))));
            this.ErrorProvider.SetIconPadding(this.HoursWorkedTextBox, ((int)(resources.GetObject("HoursWorkedTextBox.IconPadding"))));
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.ShortcutsEnabled = false;
            this.HoursWorkedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoursWorkedTextBox_KeyPress);
            this.HoursWorkedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.HoursWorkedTextBox_Validating);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            resources.ApplyResources(this.ErrorProvider, "ErrorProvider");
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
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
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
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}

