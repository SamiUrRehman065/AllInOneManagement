namespace FactoryManagementSystem.UserControls.RawMaterialLedgerControls.CrudControlsRawMaterialsLedger
{
    partial class UpdateRawMaterialsLedgerControl
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
            LblHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            ClearLeadgerCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            btnClear = new Guna.UI2.WinForms.Guna2Button();
            txtPName = new Guna.UI2.WinForms.Guna2TextBox();
            DatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            SuspendLayout();
            // 
            // LblHeader
            // 
            LblHeader.BackColor = Color.Transparent;
            LblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline);
            LblHeader.Location = new Point(101, 20);
            LblHeader.Name = "LblHeader";
            LblHeader.Size = new Size(180, 43);
            LblHeader.TabIndex = 50;
            LblHeader.TabStop = false;
            LblHeader.Text = "Clear Ledger";
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAmount.Animated = true;
            txtAmount.BorderRadius = 26;
            txtAmount.BorderThickness = 2;
            txtAmount.CustomizableEdges = customizableEdges1;
            txtAmount.DefaultText = "";
            txtAmount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAmount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAmount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAmount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAmount.Font = new Font("Segoe UI", 14F);
            txtAmount.ForeColor = Color.Black;
            txtAmount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAmount.Location = new Point(42, 190);
            txtAmount.Margin = new Padding(6, 7, 6, 7);
            txtAmount.Name = "txtAmount";
            txtAmount.Padding = new Padding(2);
            txtAmount.PasswordChar = '\0';
            txtAmount.PlaceholderForeColor = Color.Black;
            txtAmount.PlaceholderText = "Payable Amount";
            txtAmount.SelectedText = "";
            txtAmount.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtAmount.Size = new Size(350, 74);
            txtAmount.TabIndex = 46;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // ClearLeadgerCheckBox
            // 
            ClearLeadgerCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearLeadgerCheckBox.Animated = true;
            ClearLeadgerCheckBox.AutoCheck = false;
            ClearLeadgerCheckBox.AutoSize = true;
            ClearLeadgerCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ClearLeadgerCheckBox.CheckedState.BorderRadius = 0;
            ClearLeadgerCheckBox.CheckedState.BorderThickness = 0;
            ClearLeadgerCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ClearLeadgerCheckBox.CheckMarkColor = Color.FromArgb(0, 0, 192);
            ClearLeadgerCheckBox.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            ClearLeadgerCheckBox.Location = new Point(66, 380);
            ClearLeadgerCheckBox.Name = "ClearLeadgerCheckBox";
            ClearLeadgerCheckBox.Padding = new Padding(2);
            ClearLeadgerCheckBox.Size = new Size(203, 38);
            ClearLeadgerCheckBox.TabIndex = 47;
            ClearLeadgerCheckBox.Text = "Clear All Ledger";
            ClearLeadgerCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ClearLeadgerCheckBox.UncheckedState.BorderRadius = 0;
            ClearLeadgerCheckBox.UncheckedState.BorderThickness = 0;
            ClearLeadgerCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            ClearLeadgerCheckBox.CheckedChanged += ClearLeadgerCheckBox_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClear.AutoRoundedCorners = true;
            btnClear.BorderRadius = 30;
            btnClear.CustomizableEdges = customizableEdges3;
            btnClear.DisabledState.BorderColor = Color.DarkGray;
            btnClear.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClear.FillColor = Color.Red;
            btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(101, 452);
            btnClear.Name = "btnClear";
            btnClear.Padding = new Padding(2);
            btnClear.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClear.Size = new Size(224, 63);
            btnClear.TabIndex = 48;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // txtPName
            // 
            txtPName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPName.Animated = true;
            txtPName.BorderRadius = 26;
            txtPName.BorderThickness = 2;
            txtPName.CustomizableEdges = customizableEdges5;
            txtPName.DefaultText = "";
            txtPName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPName.Font = new Font("Segoe UI", 14F);
            txtPName.ForeColor = Color.Black;
            txtPName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPName.Location = new Point(42, 92);
            txtPName.Margin = new Padding(6, 7, 6, 7);
            txtPName.Name = "txtPName";
            txtPName.Padding = new Padding(2);
            txtPName.PasswordChar = '\0';
            txtPName.PlaceholderForeColor = Color.Black;
            txtPName.PlaceholderText = "Provider Name";
            txtPName.ReadOnly = true;
            txtPName.SelectedText = "";
            txtPName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPName.Size = new Size(350, 74);
            txtPName.TabIndex = 49;
            txtPName.TabStop = false;
            // 
            // DatePicker
            // 
            DatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DatePicker.Animated = true;
            DatePicker.BorderColor = SystemColors.MenuHighlight;
            DatePicker.BorderRadius = 26;
            DatePicker.Checked = true;
            DatePicker.CustomizableEdges = customizableEdges7;
            DatePicker.FillColor = Color.White;
            DatePicker.Font = new Font("Segoe UI", 12.8F);
            DatePicker.Format = DateTimePickerFormat.Long;
            DatePicker.Location = new Point(42, 287);
            DatePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DatePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DatePicker.Name = "DatePicker";
            DatePicker.ShadowDecoration.CustomizableEdges = customizableEdges8;
            DatePicker.Size = new Size(350, 74);
            DatePicker.TabIndex = 51;
            DatePicker.Value = new DateTime(2025, 3, 18, 0, 0, 0, 0);
            // 
            // UpdateRawMaterialsLedgerControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DatePicker);
            Controls.Add(LblHeader);
            Controls.Add(txtAmount);
            Controls.Add(ClearLeadgerCheckBox);
            Controls.Add(btnClear);
            Controls.Add(txtPName);
            Name = "UpdateRawMaterialsLedgerControl";
            Size = new Size(434, 616);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LblHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2CheckBox ClearLeadgerCheckBox;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2TextBox txtPName;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePicker;
    }
}
