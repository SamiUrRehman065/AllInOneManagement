namespace FactoryManagementSystem.UserControls.CashFlowControls.CrudControlsCashFlow
{
    partial class UpdateCashFlowControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cmbtype = new Guna.UI2.WinForms.Guna2ComboBox();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            lblHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtdescription = new Guna.UI2.WinForms.Guna2TextBox();
            DatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            txtReason = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // cmbtype
            // 
            cmbtype.BackColor = Color.Transparent;
            cmbtype.BorderRadius = 26;
            cmbtype.BorderThickness = 2;
            cmbtype.CustomizableEdges = customizableEdges1;
            cmbtype.DrawMode = DrawMode.OwnerDrawFixed;
            cmbtype.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtype.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbtype.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbtype.Font = new Font("Segoe UI", 14F);
            cmbtype.ForeColor = Color.Black;
            cmbtype.ItemHeight = 68;
            cmbtype.Items.AddRange(new object[] { "Inflow", "Outflow" });
            cmbtype.Location = new Point(146, 194);
            cmbtype.Name = "cmbtype";
            cmbtype.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbtype.Size = new Size(317, 74);
            cmbtype.Sorted = true;
            cmbtype.StartIndex = 0;
            cmbtype.TabIndex = 9;
            cmbtype.TextAlign = HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.AutoRoundedCorners = true;
            btnUpdate.BorderRadius = 27;
            btnUpdate.CustomizableEdges = customizableEdges3;
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.FillColor = Color.Yellow;
            btnUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(362, 431);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnUpdate.Size = new Size(225, 56);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblHeading
            // 
            lblHeading.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblHeading.BackColor = Color.Transparent;
            lblHeading.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Underline);
            lblHeading.Location = new Point(362, 27);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(233, 39);
            lblHeading.TabIndex = 13;
            lblHeading.TabStop = false;
            lblHeading.Text = "Update Cash Flow";
            // 
            // txtdescription
            // 
            txtdescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtdescription.Animated = true;
            txtdescription.BorderRadius = 26;
            txtdescription.BorderThickness = 2;
            txtdescription.CustomizableEdges = customizableEdges5;
            txtdescription.DefaultText = "";
            txtdescription.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtdescription.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtdescription.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtdescription.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtdescription.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtdescription.Font = new Font("Segoe UI", 14F);
            txtdescription.ForeColor = Color.Black;
            txtdescription.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtdescription.Location = new Point(146, 327);
            txtdescription.Margin = new Padding(6, 7, 6, 7);
            txtdescription.Multiline = true;
            txtdescription.Name = "txtdescription";
            txtdescription.PasswordChar = '\0';
            txtdescription.PlaceholderForeColor = Color.Black;
            txtdescription.PlaceholderText = " Description";
            txtdescription.SelectedText = "";
            txtdescription.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtdescription.Size = new Size(655, 74);
            txtdescription.TabIndex = 11;
            txtdescription.TextAlign = HorizontalAlignment.Center;
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
            DatePicker.Location = new Point(484, 215);
            DatePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DatePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DatePicker.Name = "DatePicker";
            DatePicker.ShadowDecoration.CustomizableEdges = customizableEdges8;
            DatePicker.Size = new Size(317, 74);
            DatePicker.TabIndex = 10;
            DatePicker.Value = new DateTime(2025, 5, 28, 19, 43, 31, 349);
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAmount.Animated = true;
            txtAmount.BorderRadius = 26;
            txtAmount.BorderThickness = 2;
            txtAmount.CustomizableEdges = customizableEdges9;
            txtAmount.DefaultText = "";
            txtAmount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAmount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAmount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAmount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAmount.Font = new Font("Segoe UI", 14F);
            txtAmount.ForeColor = Color.Black;
            txtAmount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAmount.Location = new Point(484, 91);
            txtAmount.Margin = new Padding(6, 7, 6, 7);
            txtAmount.Name = "txtAmount";
            txtAmount.PasswordChar = '\0';
            txtAmount.PlaceholderForeColor = Color.Black;
            txtAmount.PlaceholderText = "Amount";
            txtAmount.SelectedText = "";
            txtAmount.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtAmount.Size = new Size(317, 74);
            txtAmount.TabIndex = 8;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // txtReason
            // 
            txtReason.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtReason.Animated = true;
            txtReason.BorderRadius = 26;
            txtReason.BorderThickness = 2;
            txtReason.CustomizableEdges = customizableEdges11;
            txtReason.DefaultText = "";
            txtReason.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtReason.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtReason.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtReason.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtReason.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtReason.Font = new Font("Segoe UI", 14F);
            txtReason.ForeColor = Color.Black;
            txtReason.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtReason.Location = new Point(146, 91);
            txtReason.Margin = new Padding(6, 7, 6, 7);
            txtReason.Name = "txtReason";
            txtReason.PasswordChar = '\0';
            txtReason.PlaceholderForeColor = Color.Black;
            txtReason.PlaceholderText = "Reason";
            txtReason.SelectedText = "";
            txtReason.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtReason.Size = new Size(317, 74);
            txtReason.TabIndex = 7;
            // 
            // UpdateCashFlowControl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(cmbtype);
            Controls.Add(btnUpdate);
            Controls.Add(lblHeading);
            Controls.Add(txtdescription);
            Controls.Add(DatePicker);
            Controls.Add(txtAmount);
            Controls.Add(txtReason);
            Name = "UpdateCashFlowControl";
            Size = new Size(946, 514);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbtype;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeading;
        private Guna.UI2.WinForms.Guna2TextBox txtdescription;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePicker;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtReason;
    }
}
