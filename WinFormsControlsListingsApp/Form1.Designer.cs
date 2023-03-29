namespace WinFormsControlsListingsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstBoxCountries = new ListBox();
            lblCountry = new Label();
            txtBoxIndex = new TextBox();
            cmbBoxCompanies = new ComboBox();
            txtBoxCountry = new TextBox();
            btnAddCountry = new Button();
            btnDeleteCountry = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lstBoxCountries
            // 
            lstBoxCountries.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lstBoxCountries.FormattingEnabled = true;
            lstBoxCountries.ItemHeight = 30;
            lstBoxCountries.Location = new Point(22, 22);
            lstBoxCountries.Name = "lstBoxCountries";
            lstBoxCountries.SelectionMode = SelectionMode.MultiExtended;
            lstBoxCountries.Size = new Size(218, 154);
            lstBoxCountries.TabIndex = 0;
            lstBoxCountries.SelectedIndexChanged += lstBoxCountries_SelectedIndexChanged;
            lstBoxCountries.DoubleClick += lstBoxCountries_DoubleClick;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountry.Location = new Point(253, 105);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(71, 30);
            lblCountry.TabIndex = 1;
            lblCountry.Text = "label1";
            // 
            // txtBoxIndex
            // 
            txtBoxIndex.Location = new Point(253, 79);
            txtBoxIndex.Name = "txtBoxIndex";
            txtBoxIndex.Size = new Size(100, 23);
            txtBoxIndex.TabIndex = 2;
            txtBoxIndex.TextChanged += txtBoxIndex_TextChanged;
            // 
            // cmbBoxCompanies
            // 
            cmbBoxCompanies.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxCompanies.DropDownHeight = 90;
            cmbBoxCompanies.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxCompanies.FormattingEnabled = true;
            cmbBoxCompanies.IntegralHeight = false;
            cmbBoxCompanies.Location = new Point(493, 12);
            cmbBoxCompanies.MaxDropDownItems = 4;
            cmbBoxCompanies.Name = "cmbBoxCompanies";
            cmbBoxCompanies.Size = new Size(268, 38);
            cmbBoxCompanies.TabIndex = 3;
            // 
            // txtBoxCountry
            // 
            txtBoxCountry.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCountry.Location = new Point(22, 206);
            txtBoxCountry.Name = "txtBoxCountry";
            txtBoxCountry.Size = new Size(218, 36);
            txtBoxCountry.TabIndex = 4;
            // 
            // btnAddCountry
            // 
            btnAddCountry.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCountry.Location = new Point(22, 248);
            btnAddCountry.Name = "btnAddCountry";
            btnAddCountry.Size = new Size(218, 51);
            btnAddCountry.TabIndex = 5;
            btnAddCountry.Text = "Add Country";
            btnAddCountry.UseVisualStyleBackColor = true;
            btnAddCountry.Click += btnAddCountry_Click;
            // 
            // btnDeleteCountry
            // 
            btnDeleteCountry.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteCountry.Location = new Point(253, 22);
            btnDeleteCountry.Name = "btnDeleteCountry";
            btnDeleteCountry.Size = new Size(148, 51);
            btnDeleteCountry.TabIndex = 5;
            btnDeleteCountry.Text = "Del Country";
            btnDeleteCountry.UseVisualStyleBackColor = true;
            btnDeleteCountry.Click += lstBoxCountries_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnDeleteCountry);
            Controls.Add(btnAddCountry);
            Controls.Add(txtBoxCountry);
            Controls.Add(cmbBoxCompanies);
            Controls.Add(txtBoxIndex);
            Controls.Add(lblCountry);
            Controls.Add(lstBoxCountries);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBoxCountries;
        private Label lblCountry;
        private TextBox txtBoxIndex;
        private ComboBox cmbBoxCompanies;
        private TextBox txtBoxCountry;
        private Button btnAddCountry;
        private Button btnDeleteCountry;
        private Button button1;
    }
}