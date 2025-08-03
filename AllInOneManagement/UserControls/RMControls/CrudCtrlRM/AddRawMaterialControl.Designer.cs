namespace FactoryManagementSystem.UserControls.RawMaterialsControls.CrudControlsRawMaterial
{
    partial class AddRawMaterialControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            ProviderGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            VerticalSeparator = new Guna.UI2.WinForms.Guna2VSeparator();
            horizontalsep1 = new Guna.UI2.WinForms.Guna2Separator();
            horizontalsep2 = new Guna.UI2.WinForms.Guna2Separator();
            txtPName = new Guna.UI2.WinForms.Guna2TextBox();
            RawMDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtRawMdescription = new Guna.UI2.WinForms.Guna2TextBox();
            TxtPhoneNo = new Guna.UI2.WinForms.Guna2TextBox();
            txtRawMQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            txtRawMName = new Guna.UI2.WinForms.Guna2TextBox();
            txtRawMprice = new Guna.UI2.WinForms.Guna2TextBox();
            lblProviderHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            NewLeadgweCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            lblRMHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            CementCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)ProviderGridview).BeginInit();
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
            btnAdd.Location = new Point(726, 611);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Size = new Size(278, 56);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // ProviderGridview
            // 
            ProviderGridview.AllowUserToAddRows = false;
            ProviderGridview.AllowUserToDeleteRows = false;
            ProviderGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProviderGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ProviderGridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProviderGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProviderGridview.ColumnHeadersHeight = 50;
            ProviderGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ProviderGridview.DefaultCellStyle = dataGridViewCellStyle3;
            ProviderGridview.GridColor = Color.FromArgb(231, 229, 255);
            ProviderGridview.Location = new Point(7, 85);
            ProviderGridview.Margin = new Padding(5);
            ProviderGridview.MultiSelect = false;
            ProviderGridview.Name = "ProviderGridview";
            ProviderGridview.ReadOnly = true;
            ProviderGridview.RowHeadersVisible = false;
            ProviderGridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ProviderGridview.Size = new Size(516, 631);
            ProviderGridview.TabIndex = 47;
            ProviderGridview.TabStop = false;
            ProviderGridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ProviderGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            ProviderGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ProviderGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ProviderGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ProviderGridview.ThemeStyle.BackColor = Color.White;
            ProviderGridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ProviderGridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ProviderGridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ProviderGridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F);
            ProviderGridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ProviderGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ProviderGridview.ThemeStyle.HeaderStyle.Height = 50;
            ProviderGridview.ThemeStyle.ReadOnly = true;
            ProviderGridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            ProviderGridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProviderGridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 15F);
            ProviderGridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ProviderGridview.ThemeStyle.RowsStyle.Height = 32;
            ProviderGridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ProviderGridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ProviderGridview.SelectionChanged += ProviderGridview_SelectionChanged;
            // 
            // VerticalSeparator
            // 
            VerticalSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            VerticalSeparator.FillColor = Color.Silver;
            VerticalSeparator.FillThickness = 2;
            VerticalSeparator.Location = new Point(523, 2);
            VerticalSeparator.Margin = new Padding(0);
            VerticalSeparator.Name = "VerticalSeparator";
            VerticalSeparator.Size = new Size(12, 749);
            VerticalSeparator.TabIndex = 52;
            // 
            // horizontalsep1
            // 
            horizontalsep1.FillColor = Color.Silver;
            horizontalsep1.FillThickness = 2;
            horizontalsep1.Location = new Point(3, 60);
            horizontalsep1.Margin = new Padding(0);
            horizontalsep1.Name = "horizontalsep1";
            horizontalsep1.Size = new Size(523, 10);
            horizontalsep1.TabIndex = 54;
            // 
            // horizontalsep2
            // 
            horizontalsep2.FillColor = Color.Silver;
            horizontalsep2.FillThickness = 2;
            horizontalsep2.Location = new Point(529, 60);
            horizontalsep2.Name = "horizontalsep2";
            horizontalsep2.Padding = new Padding(3);
            horizontalsep2.Size = new Size(703, 10);
            horizontalsep2.TabIndex = 55;
            // 
            // txtPName
            // 
            txtPName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPName.Animated = true;
            txtPName.BorderRadius = 26;
            txtPName.BorderThickness = 2;
            txtPName.CustomizableEdges = customizableEdges3;
            txtPName.DefaultText = "";
            txtPName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPName.Font = new Font("Segoe UI", 14F);
            txtPName.ForeColor = Color.Black;
            txtPName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPName.Location = new Point(558, 154);
            txtPName.Margin = new Padding(6, 7, 6, 7);
            txtPName.Name = "txtPName";
            txtPName.Padding = new Padding(2);
            txtPName.PasswordChar = '\0';
            txtPName.PlaceholderForeColor = Color.Black;
            txtPName.PlaceholderText = "Supplier Name";
            txtPName.SelectedText = "";
            txtPName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPName.Size = new Size(313, 74);
            txtPName.TabIndex = 41;
            // 
            // RawMDatePicker
            // 
            RawMDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RawMDatePicker.Animated = true;
            RawMDatePicker.BorderColor = SystemColors.MenuHighlight;
            RawMDatePicker.BorderRadius = 26;
            RawMDatePicker.Checked = true;
            RawMDatePicker.CustomizableEdges = customizableEdges5;
            RawMDatePicker.FillColor = Color.White;
            RawMDatePicker.Font = new Font("Segoe UI", 12.8F);
            RawMDatePicker.Format = DateTimePickerFormat.Long;
            RawMDatePicker.Location = new Point(896, 366);
            RawMDatePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            RawMDatePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            RawMDatePicker.Name = "RawMDatePicker";
            RawMDatePicker.Padding = new Padding(2);
            RawMDatePicker.ShadowDecoration.CustomizableEdges = customizableEdges6;
            RawMDatePicker.Size = new Size(313, 74);
            RawMDatePicker.TabIndex = 49;
            RawMDatePicker.Value = new DateTime(2025, 2, 28, 19, 43, 31, 349);
            // 
            // txtRawMdescription
            // 
            txtRawMdescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRawMdescription.Animated = true;
            txtRawMdescription.BorderRadius = 26;
            txtRawMdescription.BorderThickness = 2;
            txtRawMdescription.CustomizableEdges = customizableEdges7;
            txtRawMdescription.DefaultText = "";
            txtRawMdescription.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRawMdescription.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRawMdescription.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRawMdescription.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRawMdescription.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRawMdescription.Font = new Font("Segoe UI", 14F);
            txtRawMdescription.ForeColor = Color.Black;
            txtRawMdescription.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRawMdescription.Location = new Point(558, 480);
            txtRawMdescription.Margin = new Padding(6, 7, 6, 7);
            txtRawMdescription.Multiline = true;
            txtRawMdescription.Name = "txtRawMdescription";
            txtRawMdescription.Padding = new Padding(2);
            txtRawMdescription.PasswordChar = '\0';
            txtRawMdescription.PlaceholderForeColor = Color.Black;
            txtRawMdescription.PlaceholderText = " Description";
            txtRawMdescription.SelectedText = "";
            txtRawMdescription.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtRawMdescription.Size = new Size(651, 74);
            txtRawMdescription.TabIndex = 59;
            txtRawMdescription.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtPhoneNo
            // 
            TxtPhoneNo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtPhoneNo.Animated = true;
            TxtPhoneNo.BorderRadius = 26;
            TxtPhoneNo.BorderThickness = 2;
            TxtPhoneNo.CustomizableEdges = customizableEdges9;
            TxtPhoneNo.DefaultText = "";
            TxtPhoneNo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxtPhoneNo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxtPhoneNo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxtPhoneNo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxtPhoneNo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtPhoneNo.Font = new Font("Segoe UI", 14F);
            TxtPhoneNo.ForeColor = Color.Black;
            TxtPhoneNo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtPhoneNo.Location = new Point(896, 154);
            TxtPhoneNo.Margin = new Padding(6, 7, 6, 7);
            TxtPhoneNo.Name = "TxtPhoneNo";
            TxtPhoneNo.Padding = new Padding(2);
            TxtPhoneNo.PasswordChar = '\0';
            TxtPhoneNo.PlaceholderForeColor = Color.Black;
            TxtPhoneNo.PlaceholderText = "Phone No.";
            TxtPhoneNo.SelectedText = "";
            TxtPhoneNo.ShadowDecoration.CustomizableEdges = customizableEdges10;
            TxtPhoneNo.Size = new Size(313, 74);
            TxtPhoneNo.TabIndex = 44;
            // 
            // txtRawMQuantity
            // 
            txtRawMQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRawMQuantity.Animated = true;
            txtRawMQuantity.BorderRadius = 26;
            txtRawMQuantity.BorderThickness = 2;
            txtRawMQuantity.CustomizableEdges = customizableEdges11;
            txtRawMQuantity.DefaultText = "";
            txtRawMQuantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRawMQuantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRawMQuantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRawMQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRawMQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRawMQuantity.Font = new Font("Segoe UI", 14F);
            txtRawMQuantity.ForeColor = Color.Black;
            txtRawMQuantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRawMQuantity.Location = new Point(896, 264);
            txtRawMQuantity.Margin = new Padding(6, 7, 6, 7);
            txtRawMQuantity.Name = "txtRawMQuantity";
            txtRawMQuantity.Padding = new Padding(2);
            txtRawMQuantity.PasswordChar = '\0';
            txtRawMQuantity.PlaceholderForeColor = Color.Black;
            txtRawMQuantity.PlaceholderText = "Quantity ";
            txtRawMQuantity.SelectedText = "";
            txtRawMQuantity.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtRawMQuantity.Size = new Size(313, 74);
            txtRawMQuantity.TabIndex = 45;
            txtRawMQuantity.KeyPress += txtRawMQuantity_KeyPress;
            // 
            // txtRawMName
            // 
            txtRawMName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRawMName.Animated = true;
            txtRawMName.BorderRadius = 26;
            txtRawMName.BorderThickness = 2;
            txtRawMName.CustomizableEdges = customizableEdges13;
            txtRawMName.DefaultText = "";
            txtRawMName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRawMName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRawMName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRawMName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRawMName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRawMName.Font = new Font("Segoe UI", 14F);
            txtRawMName.ForeColor = Color.Black;
            txtRawMName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRawMName.Location = new Point(558, 264);
            txtRawMName.Margin = new Padding(6, 7, 6, 7);
            txtRawMName.Name = "txtRawMName";
            txtRawMName.Padding = new Padding(2);
            txtRawMName.PasswordChar = '\0';
            txtRawMName.PlaceholderForeColor = Color.Black;
            txtRawMName.PlaceholderText = "Raw Material Name";
            txtRawMName.SelectedText = "";
            txtRawMName.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtRawMName.Size = new Size(313, 74);
            txtRawMName.TabIndex = 42;
            txtRawMName.TabStop = false;
            // 
            // txtRawMprice
            // 
            txtRawMprice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRawMprice.Animated = true;
            txtRawMprice.BorderRadius = 26;
            txtRawMprice.BorderThickness = 2;
            txtRawMprice.CustomizableEdges = customizableEdges15;
            txtRawMprice.DefaultText = "";
            txtRawMprice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRawMprice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRawMprice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRawMprice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRawMprice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRawMprice.Font = new Font("Segoe UI", 14F);
            txtRawMprice.ForeColor = Color.Black;
            txtRawMprice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRawMprice.Location = new Point(558, 366);
            txtRawMprice.Margin = new Padding(6, 7, 6, 7);
            txtRawMprice.Name = "txtRawMprice";
            txtRawMprice.Padding = new Padding(2);
            txtRawMprice.PasswordChar = '\0';
            txtRawMprice.PlaceholderForeColor = Color.Black;
            txtRawMprice.PlaceholderText = "Price Per Unit";
            txtRawMprice.SelectedText = "";
            txtRawMprice.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtRawMprice.Size = new Size(313, 74);
            txtRawMprice.TabIndex = 46;
            txtRawMprice.KeyPress += txtRawMprice_KeyPress;
            // 
            // lblProviderHeader
            // 
            lblProviderHeader.BackColor = Color.Transparent;
            lblProviderHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline);
            lblProviderHeader.Location = new Point(163, 14);
            lblProviderHeader.Name = "lblProviderHeader";
            lblProviderHeader.Size = new Size(122, 43);
            lblProviderHeader.TabIndex = 62;
            lblProviderHeader.TabStop = false;
            lblProviderHeader.Text = "Supplier";
            // 
            // NewLeadgweCheckBox
            // 
            NewLeadgweCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NewLeadgweCheckBox.Animated = true;
            NewLeadgweCheckBox.AutoCheck = false;
            NewLeadgweCheckBox.AutoSize = true;
            NewLeadgweCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            NewLeadgweCheckBox.CheckedState.BorderRadius = 0;
            NewLeadgweCheckBox.CheckedState.BorderThickness = 0;
            NewLeadgweCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            NewLeadgweCheckBox.CheckMarkColor = Color.FromArgb(0, 0, 192);
            NewLeadgweCheckBox.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            NewLeadgweCheckBox.Location = new Point(1066, 22);
            NewLeadgweCheckBox.Name = "NewLeadgweCheckBox";
            NewLeadgweCheckBox.Padding = new Padding(2);
            NewLeadgweCheckBox.Size = new Size(164, 38);
            NewLeadgweCheckBox.TabIndex = 64;
            NewLeadgweCheckBox.Text = "New Ledger";
            NewLeadgweCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            NewLeadgweCheckBox.UncheckedState.BorderRadius = 0;
            NewLeadgweCheckBox.UncheckedState.BorderThickness = 0;
            NewLeadgweCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            NewLeadgweCheckBox.CheckedChanged += NewLeadgweCheckBox_CheckedChanged;
            // 
            // lblRMHeader
            // 
            lblRMHeader.BackColor = Color.Transparent;
            lblRMHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline);
            lblRMHeader.Location = new Point(694, 14);
            lblRMHeader.Name = "lblRMHeader";
            lblRMHeader.Size = new Size(257, 43);
            lblRMHeader.TabIndex = 65;
            lblRMHeader.TabStop = false;
            lblRMHeader.Text = "Add Raw Material";
            // 
            // CementCheckBox
            // 
            CementCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CementCheckBox.Animated = true;
            CementCheckBox.AutoCheck = false;
            CementCheckBox.AutoSize = true;
            CementCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            CementCheckBox.CheckedState.BorderRadius = 0;
            CementCheckBox.CheckedState.BorderThickness = 0;
            CementCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            CementCheckBox.CheckMarkColor = Color.FromArgb(0, 0, 192);
            CementCheckBox.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            CementCheckBox.Location = new Point(1070, 85);
            CementCheckBox.Name = "CementCheckBox";
            CementCheckBox.Padding = new Padding(2);
            CementCheckBox.Size = new Size(119, 38);
            CementCheckBox.TabIndex = 66;
            CementCheckBox.Text = "Cement";
            CementCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            CementCheckBox.UncheckedState.BorderRadius = 0;
            CementCheckBox.UncheckedState.BorderThickness = 0;
            CementCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            CementCheckBox.CheckedChanged += CementCheckBox_CheckedChanged;
            // 
            // AddRawMaterialControl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(CementCheckBox);
            Controls.Add(lblRMHeader);
            Controls.Add(NewLeadgweCheckBox);
            Controls.Add(lblProviderHeader);
            Controls.Add(txtRawMprice);
            Controls.Add(txtRawMName);
            Controls.Add(txtRawMQuantity);
            Controls.Add(TxtPhoneNo);
            Controls.Add(txtRawMdescription);
            Controls.Add(RawMDatePicker);
            Controls.Add(txtPName);
            Controls.Add(horizontalsep2);
            Controls.Add(horizontalsep1);
            Controls.Add(VerticalSeparator);
            Controls.Add(ProviderGridview);
            Controls.Add(btnAdd);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "AddRawMaterialControl";
            Padding = new Padding(2);
            Size = new Size(1234, 753);
            ((System.ComponentModel.ISupportInitialize)ProviderGridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2DataGridView ProviderGridview;
        private Guna.UI2.WinForms.Guna2VSeparator VerticalSeparator;
        private Guna.UI2.WinForms.Guna2Separator horizontalsep1;
        private Guna.UI2.WinForms.Guna2Separator horizontalsep2;
        private Guna.UI2.WinForms.Guna2TextBox txtPName;
        private Guna.UI2.WinForms.Guna2TextBox txtCNIC;
        private Guna.UI2.WinForms.Guna2DateTimePicker RawMDatePicker;
        private Guna.UI2.WinForms.Guna2TextBox txtRawMdescription;
        private Guna.UI2.WinForms.Guna2TextBox TxtPhoneNo;
        private Guna.UI2.WinForms.Guna2TextBox txtRawMQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtRawMName;
        private Guna.UI2.WinForms.Guna2TextBox txtRawMprice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProviderHeader;
        private Guna.UI2.WinForms.Guna2CheckBox NewLeadgweCheckBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRMHeader;
        private Guna.UI2.WinForms.Guna2CheckBox CementCheckBox;
    }
}
