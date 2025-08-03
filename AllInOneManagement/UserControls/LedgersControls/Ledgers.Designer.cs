namespace FactoryManagementSystem.UserControls
{
    partial class Ledgers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ledgers));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tablelayoutledgerpage = new TableLayoutPanel();
            LedgerClearanceGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            EndDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            startdate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            EndDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            StartDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btndelete = new Button();
            PrintRecordbtn = new Button();
            btnClearLedger = new Button();
            LedgerGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            CustomerGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            OrderGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            tablelayoutledgerpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LedgerClearanceGridview).BeginInit();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LedgerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).BeginInit();
            SuspendLayout();
            // 
            // tablelayoutledgerpage
            // 
            tablelayoutledgerpage.ColumnCount = 2;
            tablelayoutledgerpage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablelayoutledgerpage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablelayoutledgerpage.Controls.Add(LedgerClearanceGridview, 0, 2);
            tablelayoutledgerpage.Controls.Add(guna2Panel1, 0, 3);
            tablelayoutledgerpage.Controls.Add(LedgerGridView, 1, 0);
            tablelayoutledgerpage.Controls.Add(CustomerGridView, 0, 0);
            tablelayoutledgerpage.Controls.Add(OrderGridView, 0, 1);
            tablelayoutledgerpage.Dock = DockStyle.Fill;
            tablelayoutledgerpage.Location = new Point(0, 0);
            tablelayoutledgerpage.Name = "tablelayoutledgerpage";
            tablelayoutledgerpage.RowCount = 4;
            tablelayoutledgerpage.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tablelayoutledgerpage.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tablelayoutledgerpage.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tablelayoutledgerpage.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tablelayoutledgerpage.Size = new Size(1111, 665);
            tablelayoutledgerpage.TabIndex = 1;
            // 
            // LedgerClearanceGridview
            // 
            LedgerClearanceGridview.AllowUserToAddRows = false;
            LedgerClearanceGridview.AllowUserToDeleteRows = false;
            LedgerClearanceGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            LedgerClearanceGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            LedgerClearanceGridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            LedgerClearanceGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            LedgerClearanceGridview.ColumnHeadersHeight = 50;
            LedgerClearanceGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tablelayoutledgerpage.SetColumnSpan(LedgerClearanceGridview, 2);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            LedgerClearanceGridview.DefaultCellStyle = dataGridViewCellStyle3;
            LedgerClearanceGridview.Dock = DockStyle.Fill;
            LedgerClearanceGridview.GridColor = Color.FromArgb(231, 229, 255);
            LedgerClearanceGridview.Location = new Point(5, 449);
            LedgerClearanceGridview.Margin = new Padding(5);
            LedgerClearanceGridview.MultiSelect = false;
            LedgerClearanceGridview.Name = "LedgerClearanceGridview";
            LedgerClearanceGridview.ReadOnly = true;
            LedgerClearanceGridview.RowHeadersVisible = false;
            LedgerClearanceGridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            LedgerClearanceGridview.Size = new Size(1101, 156);
            LedgerClearanceGridview.TabIndex = 13;
            LedgerClearanceGridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            LedgerClearanceGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            LedgerClearanceGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            LedgerClearanceGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            LedgerClearanceGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            LedgerClearanceGridview.ThemeStyle.BackColor = Color.White;
            LedgerClearanceGridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            LedgerClearanceGridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            LedgerClearanceGridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            LedgerClearanceGridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F);
            LedgerClearanceGridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            LedgerClearanceGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            LedgerClearanceGridview.ThemeStyle.HeaderStyle.Height = 50;
            LedgerClearanceGridview.ThemeStyle.ReadOnly = true;
            LedgerClearanceGridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            LedgerClearanceGridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            LedgerClearanceGridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 15F);
            LedgerClearanceGridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            LedgerClearanceGridview.ThemeStyle.RowsStyle.Height = 32;
            LedgerClearanceGridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            LedgerClearanceGridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.SteelBlue;
            guna2Panel1.BorderColor = Color.SkyBlue;
            guna2Panel1.BorderThickness = 2;
            tablelayoutledgerpage.SetColumnSpan(guna2Panel1, 2);
            guna2Panel1.Controls.Add(EndDate);
            guna2Panel1.Controls.Add(startdate);
            guna2Panel1.Controls.Add(EndDatePicker);
            guna2Panel1.Controls.Add(StartDatePicker);
            guna2Panel1.Controls.Add(btndelete);
            guna2Panel1.Controls.Add(PrintRecordbtn);
            guna2Panel1.Controls.Add(btnClearLedger);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(4, 614);
            guna2Panel1.Margin = new Padding(4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Padding = new Padding(4);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(1103, 47);
            guna2Panel1.TabIndex = 12;
            // 
            // EndDate
            // 
            EndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EndDate.BackColor = Color.Transparent;
            EndDate.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            EndDate.ForeColor = SystemColors.ButtonHighlight;
            EndDate.Location = new Point(808, 7);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(56, 43);
            EndDate.TabIndex = 17;
            EndDate.TabStop = false;
            EndDate.Text = "End";
            // 
            // startdate
            // 
            startdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            startdate.BackColor = Color.Transparent;
            startdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            startdate.ForeColor = SystemColors.ButtonHighlight;
            startdate.Location = new Point(505, 8);
            startdate.Name = "startdate";
            startdate.Size = new Size(72, 43);
            startdate.TabIndex = 16;
            startdate.TabStop = false;
            startdate.Text = "Start";
            // 
            // EndDatePicker
            // 
            EndDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EndDatePicker.Animated = true;
            EndDatePicker.Checked = true;
            EndDatePicker.CustomizableEdges = customizableEdges1;
            EndDatePicker.Font = new Font("Microsoft Sans Serif", 18F);
            EndDatePicker.Format = DateTimePickerFormat.Short;
            EndDatePicker.Location = new Point(875, 6);
            EndDatePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            EndDatePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.ShadowDecoration.CustomizableEdges = customizableEdges2;
            EndDatePicker.Size = new Size(209, 43);
            EndDatePicker.TabIndex = 15;
            EndDatePicker.Value = new DateTime(2025, 3, 16, 22, 36, 24, 480);
            // 
            // StartDatePicker
            // 
            StartDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            StartDatePicker.Animated = true;
            StartDatePicker.Checked = true;
            StartDatePicker.CustomizableEdges = customizableEdges3;
            StartDatePicker.Font = new Font("Microsoft Sans Serif", 18F);
            StartDatePicker.Format = DateTimePickerFormat.Short;
            StartDatePicker.Location = new Point(588, 8);
            StartDatePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            StartDatePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.ShadowDecoration.CustomizableEdges = customizableEdges4;
            StartDatePicker.Size = new Size(209, 43);
            StartDatePicker.TabIndex = 14;
            StartDatePicker.Value = new DateTime(2025, 3, 16, 22, 36, 24, 480);
            // 
            // btndelete
            // 
            btndelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btndelete.BackColor = Color.Transparent;
            btndelete.BackgroundImage = (Image)resources.GetObject("btndelete.BackgroundImage");
            btndelete.BackgroundImageLayout = ImageLayout.None;
            btndelete.FlatAppearance.BorderSize = 0;
            btndelete.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = Color.Transparent;
            btndelete.ImageAlign = ContentAlignment.MiddleLeft;
            btndelete.Location = new Point(187, 8);
            btndelete.Margin = new Padding(2);
            btndelete.Name = "btndelete";
            btndelete.Padding = new Padding(2);
            btndelete.Size = new Size(255, 33);
            btndelete.TabIndex = 12;
            btndelete.Text = "      Delete Record";
            btndelete.TextAlign = ContentAlignment.MiddleLeft;
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // PrintRecordbtn
            // 
            PrintRecordbtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PrintRecordbtn.BackColor = Color.Transparent;
            PrintRecordbtn.BackgroundImage = (Image)resources.GetObject("PrintRecordbtn.BackgroundImage");
            PrintRecordbtn.BackgroundImageLayout = ImageLayout.None;
            PrintRecordbtn.FlatAppearance.BorderSize = 0;
            PrintRecordbtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            PrintRecordbtn.FlatStyle = FlatStyle.Flat;
            PrintRecordbtn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrintRecordbtn.ForeColor = Color.Transparent;
            PrintRecordbtn.ImageAlign = ContentAlignment.MiddleLeft;
            PrintRecordbtn.Location = new Point(462, 6);
            PrintRecordbtn.Name = "PrintRecordbtn";
            PrintRecordbtn.Padding = new Padding(3);
            PrintRecordbtn.Size = new Size(146, 34);
            PrintRecordbtn.TabIndex = 13;
            PrintRecordbtn.Text = "      Print";
            PrintRecordbtn.TextAlign = ContentAlignment.MiddleLeft;
            PrintRecordbtn.UseVisualStyleBackColor = false;
            PrintRecordbtn.Click += PrintRecordbtn_Click;
            // 
            // btnClearLedger
            // 
            btnClearLedger.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnClearLedger.BackColor = Color.Transparent;
            btnClearLedger.BackgroundImage = (Image)resources.GetObject("btnClearLedger.BackgroundImage");
            btnClearLedger.BackgroundImageLayout = ImageLayout.None;
            btnClearLedger.FlatAppearance.BorderSize = 0;
            btnClearLedger.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnClearLedger.FlatStyle = FlatStyle.Flat;
            btnClearLedger.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearLedger.ForeColor = Color.Transparent;
            btnClearLedger.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearLedger.Location = new Point(7, 6);
            btnClearLedger.Name = "btnClearLedger";
            btnClearLedger.Padding = new Padding(3);
            btnClearLedger.Size = new Size(156, 34);
            btnClearLedger.TabIndex = 11;
            btnClearLedger.Text = "      Clear Ledger";
            btnClearLedger.TextAlign = ContentAlignment.MiddleLeft;
            btnClearLedger.UseVisualStyleBackColor = false;
            btnClearLedger.Click += btnClearLedger_Click;
            // 
            // LedgerGridView
            // 
            LedgerGridView.AllowUserToAddRows = false;
            LedgerGridView.AllowUserToDeleteRows = false;
            LedgerGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            LedgerGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            LedgerGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            LedgerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            LedgerGridView.ColumnHeadersHeight = 50;
            LedgerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            LedgerGridView.DefaultCellStyle = dataGridViewCellStyle6;
            LedgerGridView.Dock = DockStyle.Fill;
            LedgerGridView.GridColor = Color.FromArgb(231, 229, 255);
            LedgerGridView.Location = new Point(560, 5);
            LedgerGridView.Margin = new Padding(5);
            LedgerGridView.MultiSelect = false;
            LedgerGridView.Name = "LedgerGridView";
            LedgerGridView.ReadOnly = true;
            LedgerGridView.RowHeadersVisible = false;
            LedgerGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            LedgerGridView.Size = new Size(546, 202);
            LedgerGridView.TabIndex = 9;
            LedgerGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            LedgerGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            LedgerGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            LedgerGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            LedgerGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            LedgerGridView.ThemeStyle.BackColor = Color.White;
            LedgerGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            LedgerGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            LedgerGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            LedgerGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F);
            LedgerGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            LedgerGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            LedgerGridView.ThemeStyle.HeaderStyle.Height = 50;
            LedgerGridView.ThemeStyle.ReadOnly = true;
            LedgerGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            LedgerGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            LedgerGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 15F);
            LedgerGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            LedgerGridView.ThemeStyle.RowsStyle.Height = 32;
            LedgerGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            LedgerGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            LedgerGridView.SelectionChanged += LedgerGridView_SelectionChanged;
            // 
            // CustomerGridView
            // 
            CustomerGridView.AllowUserToAddRows = false;
            CustomerGridView.AllowUserToDeleteRows = false;
            CustomerGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            CustomerGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            CustomerGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle8.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            CustomerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            CustomerGridView.ColumnHeadersHeight = 50;
            CustomerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            CustomerGridView.DefaultCellStyle = dataGridViewCellStyle9;
            CustomerGridView.Dock = DockStyle.Fill;
            CustomerGridView.GridColor = Color.FromArgb(231, 229, 255);
            CustomerGridView.Location = new Point(5, 5);
            CustomerGridView.Margin = new Padding(5);
            CustomerGridView.MultiSelect = false;
            CustomerGridView.Name = "CustomerGridView";
            CustomerGridView.ReadOnly = true;
            CustomerGridView.RowHeadersVisible = false;
            CustomerGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            CustomerGridView.Size = new Size(545, 202);
            CustomerGridView.TabIndex = 8;
            CustomerGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CustomerGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            CustomerGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CustomerGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CustomerGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CustomerGridView.ThemeStyle.BackColor = Color.White;
            CustomerGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            CustomerGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            CustomerGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CustomerGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F);
            CustomerGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CustomerGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CustomerGridView.ThemeStyle.HeaderStyle.Height = 50;
            CustomerGridView.ThemeStyle.ReadOnly = true;
            CustomerGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            CustomerGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CustomerGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 15F);
            CustomerGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            CustomerGridView.ThemeStyle.RowsStyle.Height = 32;
            CustomerGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            CustomerGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            CustomerGridView.SelectionChanged += CustomerGridView_SelectionChanged;
            // 
            // OrderGridView
            // 
            OrderGridView.AllowUserToAddRows = false;
            OrderGridView.AllowUserToDeleteRows = false;
            OrderGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            OrderGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            OrderGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle11.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            OrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            OrderGridView.ColumnHeadersHeight = 69;
            OrderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tablelayoutledgerpage.SetColumnSpan(OrderGridView, 2);
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            OrderGridView.DefaultCellStyle = dataGridViewCellStyle12;
            OrderGridView.Dock = DockStyle.Fill;
            OrderGridView.GridColor = Color.FromArgb(231, 229, 255);
            OrderGridView.Location = new Point(5, 217);
            OrderGridView.Margin = new Padding(5);
            OrderGridView.MultiSelect = false;
            OrderGridView.Name = "OrderGridView";
            OrderGridView.ReadOnly = true;
            OrderGridView.RowHeadersVisible = false;
            OrderGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            OrderGridView.Size = new Size(1101, 222);
            OrderGridView.TabIndex = 6;
            OrderGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            OrderGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            OrderGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            OrderGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            OrderGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            OrderGridView.ThemeStyle.BackColor = Color.White;
            OrderGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            OrderGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            OrderGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            OrderGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F);
            OrderGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            OrderGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            OrderGridView.ThemeStyle.HeaderStyle.Height = 69;
            OrderGridView.ThemeStyle.ReadOnly = true;
            OrderGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            OrderGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            OrderGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 15F);
            OrderGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            OrderGridView.ThemeStyle.RowsStyle.Height = 32;
            OrderGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            OrderGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Ledgers
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(tablelayoutledgerpage);
            DoubleBuffered = true;
            Name = "Ledgers";
            Size = new Size(1111, 665);
            tablelayoutledgerpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LedgerClearanceGridview).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LedgerGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tablelayoutledgerpage;
        private Guna.UI2.WinForms.Guna2DataGridView OrderGridView;
        private Guna.UI2.WinForms.Guna2DataGridView LedgerGridView;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerGridView;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Button btnClearLedger;
        private Guna.UI2.WinForms.Guna2DataGridView LedgerClearanceGridview;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button PrintRecordbtn;
        private Button btndelete;
        private Guna.UI2.WinForms.Guna2DateTimePicker EndDatePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker StartDatePicker;
        private Guna.UI2.WinForms.Guna2HtmlLabel EndDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel startdate;
    }
}
