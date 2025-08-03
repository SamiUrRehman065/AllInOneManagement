namespace FactoryManagementSystem.UserControls.RawMaterialLedgerControls
{
    partial class RawMaterialLedger
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawMaterialLedger));
            tablelayoutledgerpage = new TableLayoutPanel();
            LedgerClearanceGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            FooterPanel = new Guna.UI2.WinForms.Guna2Panel();
            btnClearLedger = new Button();
            LedgerGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ProviderGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            RMGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            btndelete = new Button();
            tablelayoutledgerpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LedgerClearanceGridview).BeginInit();
            FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LedgerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProviderGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RMGridView).BeginInit();
            SuspendLayout();
            // 
            // tablelayoutledgerpage
            // 
            tablelayoutledgerpage.ColumnCount = 2;
            tablelayoutledgerpage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablelayoutledgerpage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablelayoutledgerpage.Controls.Add(LedgerClearanceGridview, 0, 2);
            tablelayoutledgerpage.Controls.Add(FooterPanel, 0, 3);
            tablelayoutledgerpage.Controls.Add(LedgerGridView, 1, 0);
            tablelayoutledgerpage.Controls.Add(ProviderGridView, 0, 0);
            tablelayoutledgerpage.Controls.Add(RMGridView, 0, 1);
            tablelayoutledgerpage.Dock = DockStyle.Fill;
            tablelayoutledgerpage.Location = new Point(0, 0);
            tablelayoutledgerpage.Name = "tablelayoutledgerpage";
            tablelayoutledgerpage.RowCount = 4;
            tablelayoutledgerpage.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tablelayoutledgerpage.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tablelayoutledgerpage.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tablelayoutledgerpage.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tablelayoutledgerpage.Size = new Size(1111, 665);
            tablelayoutledgerpage.TabIndex = 2;
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
            // FooterPanel
            // 
            FooterPanel.BackColor = Color.SteelBlue;
            FooterPanel.BorderColor = Color.SkyBlue;
            FooterPanel.BorderThickness = 2;
            tablelayoutledgerpage.SetColumnSpan(FooterPanel, 2);
            FooterPanel.Controls.Add(btndelete);
            FooterPanel.Controls.Add(btnClearLedger);
            FooterPanel.CustomizableEdges = customizableEdges1;
            FooterPanel.Dock = DockStyle.Fill;
            FooterPanel.Location = new Point(4, 614);
            FooterPanel.Margin = new Padding(4);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Padding = new Padding(4);
            FooterPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            FooterPanel.Size = new Size(1103, 47);
            FooterPanel.TabIndex = 12;
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
            btnClearLedger.Location = new Point(11, 7);
            btnClearLedger.Name = "btnClearLedger";
            btnClearLedger.Padding = new Padding(3);
            btnClearLedger.Size = new Size(187, 33);
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
            // ProviderGridView
            // 
            ProviderGridView.AllowUserToAddRows = false;
            ProviderGridView.AllowUserToDeleteRows = false;
            ProviderGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            ProviderGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            ProviderGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle8.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            ProviderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            ProviderGridView.ColumnHeadersHeight = 50;
            ProviderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            ProviderGridView.DefaultCellStyle = dataGridViewCellStyle9;
            ProviderGridView.Dock = DockStyle.Fill;
            ProviderGridView.GridColor = Color.FromArgb(231, 229, 255);
            ProviderGridView.Location = new Point(5, 5);
            ProviderGridView.Margin = new Padding(5);
            ProviderGridView.MultiSelect = false;
            ProviderGridView.Name = "ProviderGridView";
            ProviderGridView.ReadOnly = true;
            ProviderGridView.RowHeadersVisible = false;
            ProviderGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ProviderGridView.Size = new Size(545, 202);
            ProviderGridView.TabIndex = 8;
            ProviderGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ProviderGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            ProviderGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ProviderGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ProviderGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ProviderGridView.ThemeStyle.BackColor = Color.White;
            ProviderGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ProviderGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ProviderGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ProviderGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F);
            ProviderGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ProviderGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ProviderGridView.ThemeStyle.HeaderStyle.Height = 50;
            ProviderGridView.ThemeStyle.ReadOnly = true;
            ProviderGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            ProviderGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProviderGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 15F);
            ProviderGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ProviderGridView.ThemeStyle.RowsStyle.Height = 32;
            ProviderGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ProviderGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ProviderGridView.SelectionChanged += ProviderGridView_SelectionChanged;
            // 
            // RMGridView
            // 
            RMGridView.AllowUserToAddRows = false;
            RMGridView.AllowUserToDeleteRows = false;
            RMGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            RMGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            RMGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle11.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            RMGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            RMGridView.ColumnHeadersHeight = 69;
            RMGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tablelayoutledgerpage.SetColumnSpan(RMGridView, 2);
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            RMGridView.DefaultCellStyle = dataGridViewCellStyle12;
            RMGridView.Dock = DockStyle.Fill;
            RMGridView.GridColor = Color.FromArgb(231, 229, 255);
            RMGridView.Location = new Point(5, 217);
            RMGridView.Margin = new Padding(5);
            RMGridView.MultiSelect = false;
            RMGridView.Name = "RMGridView";
            RMGridView.ReadOnly = true;
            RMGridView.RowHeadersVisible = false;
            RMGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            RMGridView.Size = new Size(1101, 222);
            RMGridView.TabIndex = 6;
            RMGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            RMGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            RMGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            RMGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            RMGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            RMGridView.ThemeStyle.BackColor = Color.White;
            RMGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            RMGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            RMGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            RMGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F);
            RMGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            RMGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            RMGridView.ThemeStyle.HeaderStyle.Height = 69;
            RMGridView.ThemeStyle.ReadOnly = true;
            RMGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            RMGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            RMGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 15F);
            RMGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            RMGridView.ThemeStyle.RowsStyle.Height = 32;
            RMGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            RMGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            btndelete.Location = new Point(246, 9);
            btndelete.Margin = new Padding(2);
            btndelete.Name = "btndelete";
            btndelete.Padding = new Padding(2);
            btndelete.Size = new Size(318, 30);
            btndelete.TabIndex = 12;
            btndelete.Text = "      Delete Record";
            btndelete.TextAlign = ContentAlignment.MiddleLeft;
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // RawMaterialLedger
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tablelayoutledgerpage);
            Name = "RawMaterialLedger";
            Size = new Size(1111, 665);
            tablelayoutledgerpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LedgerClearanceGridview).EndInit();
            FooterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LedgerGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProviderGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)RMGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablelayoutledgerpage;
        private Guna.UI2.WinForms.Guna2DataGridView LedgerClearanceGridview;
        private Guna.UI2.WinForms.Guna2Panel FooterPanel;
        private Button btnClearLedger;
        private Guna.UI2.WinForms.Guna2DataGridView LedgerGridView;
        private Guna.UI2.WinForms.Guna2DataGridView ProviderGridView;
        private Guna.UI2.WinForms.Guna2DataGridView RMGridView;
        private Button btndelete;
    }
}
