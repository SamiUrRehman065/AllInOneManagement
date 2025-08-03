namespace FactoryManagementSystem.UserControls.LedgersControls.CrudControlsLedger
{
    partial class UpdateLedgerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ClearLeadgweCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            btnClear = new Guna.UI2.WinForms.Guna2Button();
            txtCName = new Guna.UI2.WinForms.Guna2TextBox();
            txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            LblHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            DatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            SuspendLayout();
            // 
            // ClearLeadgweCheckBox
            // 
            ClearLeadgweCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearLeadgweCheckBox.Animated = true;
            ClearLeadgweCheckBox.AutoCheck = false;
            ClearLeadgweCheckBox.AutoSize = true;
            ClearLeadgweCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ClearLeadgweCheckBox.CheckedState.BorderRadius = 0;
            ClearLeadgweCheckBox.CheckedState.BorderThickness = 0;
            ClearLeadgweCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ClearLeadgweCheckBox.CheckMarkColor = Color.FromArgb(0, 0, 192);
            ClearLeadgweCheckBox.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            ClearLeadgweCheckBox.Location = new Point(42, 432);
            ClearLeadgweCheckBox.Name = "ClearLeadgweCheckBox";
            ClearLeadgweCheckBox.Padding = new Padding(2);
            ClearLeadgweCheckBox.Size = new Size(203, 38);
            ClearLeadgweCheckBox.TabIndex = 3;
            ClearLeadgweCheckBox.Text = "Clear All Ledger";
            ClearLeadgweCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ClearLeadgweCheckBox.UncheckedState.BorderRadius = 0;
            ClearLeadgweCheckBox.UncheckedState.BorderThickness = 0;
            ClearLeadgweCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            ClearLeadgweCheckBox.CheckedChanged += ClearLeadgweCheckBox_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClear.AutoRoundedCorners = true;
            btnClear.BorderRadius = 30;
            btnClear.CustomizableEdges = customizableEdges1;
            btnClear.DisabledState.BorderColor = Color.DarkGray;
            btnClear.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClear.FillColor = Color.Red;
            btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(101, 496);
            btnClear.Name = "btnClear";
            btnClear.Padding = new Padding(2);
            btnClear.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClear.Size = new Size(200, 63);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // txtCName
            // 
            txtCName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCName.Animated = true;
            txtCName.BorderRadius = 26;
            txtCName.BorderThickness = 2;
            txtCName.CustomizableEdges = customizableEdges3;
            txtCName.DefaultText = "";
            txtCName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCName.Font = new Font("Segoe UI", 14F);
            txtCName.ForeColor = Color.Black;
            txtCName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCName.Location = new Point(42, 78);
            txtCName.Margin = new Padding(6, 7, 6, 7);
            txtCName.Name = "txtCName";
            txtCName.Padding = new Padding(2);
            txtCName.PasswordChar = '\0';
            txtCName.PlaceholderForeColor = Color.Black;
            txtCName.PlaceholderText = "Customer Name";
            txtCName.ReadOnly = true;
            txtCName.SelectedText = "";
            txtCName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtCName.Size = new Size(326, 74);
            txtCName.TabIndex = 41;
            txtCName.TabStop = false;
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAmount.Animated = true;
            txtAmount.BorderRadius = 26;
            txtAmount.BorderThickness = 2;
            txtAmount.CustomizableEdges = customizableEdges5;
            txtAmount.DefaultText = "";
            txtAmount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAmount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAmount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAmount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAmount.Font = new Font("Segoe UI", 14F);
            txtAmount.ForeColor = Color.Black;
            txtAmount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAmount.Location = new Point(42, 168);
            txtAmount.Margin = new Padding(6, 7, 6, 7);
            txtAmount.Name = "txtAmount";
            txtAmount.Padding = new Padding(2);
            txtAmount.PasswordChar = '\0';
            txtAmount.PlaceholderForeColor = Color.Black;
            txtAmount.PlaceholderText = "Receivable Amount";
            txtAmount.SelectedText = "";
            txtAmount.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtAmount.Size = new Size(326, 74);
            txtAmount.TabIndex = 0;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // LblHeader
            // 
            LblHeader.BackColor = Color.Transparent;
            LblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline);
            LblHeader.Location = new Point(101, 11);
            LblHeader.Name = "LblHeader";
            LblHeader.Size = new Size(180, 43);
            LblHeader.TabIndex = 45;
            LblHeader.TabStop = false;
            LblHeader.Text = "Clear Ledger";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Animated = true;
            txtDescription.BorderRadius = 26;
            txtDescription.BorderThickness = 2;
            txtDescription.CustomizableEdges = customizableEdges7;
            txtDescription.DefaultText = "";
            txtDescription.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescription.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescription.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescription.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescription.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescription.Font = new Font("Segoe UI", 14F);
            txtDescription.ForeColor = Color.Black;
            txtDescription.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescription.Location = new Point(42, 259);
            txtDescription.Margin = new Padding(6, 7, 6, 7);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Padding = new Padding(2);
            txtDescription.PasswordChar = '\0';
            txtDescription.PlaceholderForeColor = Color.Black;
            txtDescription.PlaceholderText = "Description";
            txtDescription.SelectedText = "";
            txtDescription.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtDescription.Size = new Size(326, 74);
            txtDescription.TabIndex = 2;
            // 
            // DatePicker
            // 
            DatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DatePicker.Animated = true;
            DatePicker.BorderColor = SystemColors.MenuHighlight;
            DatePicker.BorderRadius = 26;
            DatePicker.Checked = true;
            DatePicker.CustomizableEdges = customizableEdges9;
            DatePicker.FillColor = Color.White;
            DatePicker.Font = new Font("Segoe UI", 12.8F);
            DatePicker.Format = DateTimePickerFormat.Long;
            DatePicker.Location = new Point(42, 347);
            DatePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DatePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DatePicker.Name = "DatePicker";
            DatePicker.ShadowDecoration.CustomizableEdges = customizableEdges10;
            DatePicker.Size = new Size(326, 74);
            DatePicker.TabIndex = 46;
            DatePicker.Value = new DateTime(2025, 3, 18, 0, 0, 0, 0);
            // 
            // UpdateLedgerControl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(DatePicker);
            Controls.Add(txtDescription);
            Controls.Add(LblHeader);
            Controls.Add(txtAmount);
            Controls.Add(ClearLeadgweCheckBox);
            Controls.Add(btnClear);
            Controls.Add(txtCName);
            Name = "UpdateLedgerControl";
            Size = new Size(410, 617);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox ClearLeadgweCheckBox;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2TextBox txtCName;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePicker;
    }
}
