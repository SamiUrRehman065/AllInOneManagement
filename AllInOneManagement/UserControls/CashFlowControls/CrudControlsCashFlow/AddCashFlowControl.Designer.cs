namespace FactoryManagementSystem.UserControls.CashFlowControls.CrudControlsCashFlow
{
    partial class AddCashFlowControl
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
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            lblHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtdescription = new Guna.UI2.WinForms.Guna2TextBox();
            DatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            txtReason = new Guna.UI2.WinForms.Guna2TextBox();
            cmbtype = new Guna.UI2.WinForms.Guna2ComboBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.AutoRoundedCorners = true;
            btnAdd.BorderRadius = 27;
            btnAdd.CustomizableEdges = customizableEdges1;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(362, 431);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Size = new Size(225, 56);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblHeading
            // 
            lblHeading.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblHeading.BackColor = Color.Transparent;
            lblHeading.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Underline);
            lblHeading.Location = new Point(362, 27);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(191, 39);
            lblHeading.TabIndex = 6;
            lblHeading.TabStop = false;
            lblHeading.Text = "Add Cash Flow";
            // 
            // txtdescription
            // 
            txtdescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtdescription.Animated = true;
            txtdescription.BorderRadius = 26;
            txtdescription.BorderThickness = 2;
            txtdescription.CustomizableEdges = customizableEdges3;
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
            txtdescription.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtdescription.Size = new Size(655, 74);
            txtdescription.TabIndex = 4;
            txtdescription.TextAlign = HorizontalAlignment.Center;
            // 
            // DatePicker
            // 
            DatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DatePicker.Animated = true;
            DatePicker.BorderColor = SystemColors.MenuHighlight;
            DatePicker.BorderRadius = 26;
            DatePicker.Checked = true;
            DatePicker.CustomizableEdges = customizableEdges5;
            DatePicker.FillColor = Color.White;
            DatePicker.Font = new Font("Segoe UI", 12.8F);
            DatePicker.Format = DateTimePickerFormat.Long;
            DatePicker.Location = new Point(484, 215);
            DatePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DatePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DatePicker.Name = "DatePicker";
            DatePicker.ShadowDecoration.CustomizableEdges = customizableEdges6;
            DatePicker.Size = new Size(317, 74);
            DatePicker.TabIndex = 3;
            DatePicker.Value = new DateTime(2025, 5, 28, 19, 43, 31, 349);
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAmount.Animated = true;
            txtAmount.BorderRadius = 26;
            txtAmount.BorderThickness = 2;
            txtAmount.CustomizableEdges = customizableEdges7;
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
            txtAmount.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtAmount.Size = new Size(317, 74);
            txtAmount.TabIndex = 1;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // txtReason
            // 
            txtReason.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtReason.Animated = true;
            txtReason.BorderRadius = 26;
            txtReason.BorderThickness = 2;
            txtReason.CustomizableEdges = customizableEdges9;
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
            txtReason.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtReason.Size = new Size(317, 74);
            txtReason.TabIndex = 0;
            // 
            // cmbtype
            // 
            cmbtype.BackColor = Color.Transparent;
            cmbtype.BorderRadius = 26;
            cmbtype.BorderThickness = 2;
            cmbtype.CustomizableEdges = customizableEdges11;
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
            cmbtype.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cmbtype.Size = new Size(317, 74);
            cmbtype.Sorted = true;
            cmbtype.StartIndex = 0;
            cmbtype.TabIndex = 2;
            cmbtype.TextAlign = HorizontalAlignment.Center;
            // 
            // AddCashFlowControl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(cmbtype);
            Controls.Add(btnAdd);
            Controls.Add(lblHeading);
            Controls.Add(txtdescription);
            Controls.Add(DatePicker);
            Controls.Add(txtAmount);
            Controls.Add(txtReason);
            Name = "AddCashFlowControl";
            Size = new Size(946, 514);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeading;
        private Guna.UI2.WinForms.Guna2TextBox txtdescription;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePicker;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtReason;
        private Guna.UI2.WinForms.Guna2ComboBox cmbtype;
    }
}
