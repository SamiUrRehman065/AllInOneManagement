namespace FactoryManagementSystem.UserControls
{
    partial class Orders
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            tablelayoutorderspage = new TableLayoutPanel();
            ordersgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            orderbtnpanel = new Guna.UI2.WinForms.Guna2Panel();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btndeleteorders = new Button();
            btnaddOrders = new Button();
            tablelayoutorderspage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersgridview).BeginInit();
            orderbtnpanel.SuspendLayout();
            SuspendLayout();
            // 
            // tablelayoutorderspage
            // 
            tablelayoutorderspage.ColumnCount = 1;
            tablelayoutorderspage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablelayoutorderspage.Controls.Add(ordersgridview, 0, 0);
            tablelayoutorderspage.Controls.Add(orderbtnpanel, 0, 1);
            tablelayoutorderspage.Dock = DockStyle.Fill;
            tablelayoutorderspage.Location = new Point(0, 0);
            tablelayoutorderspage.Name = "tablelayoutorderspage";
            tablelayoutorderspage.RowCount = 2;
            tablelayoutorderspage.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tablelayoutorderspage.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tablelayoutorderspage.Size = new Size(1111, 665);
            tablelayoutorderspage.TabIndex = 0;
            // 
            // ordersgridview
            // 
            ordersgridview.AllowUserToAddRows = false;
            ordersgridview.AllowUserToDeleteRows = false;
            ordersgridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ordersgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ordersgridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ordersgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ordersgridview.ColumnHeadersHeight = 69;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ordersgridview.DefaultCellStyle = dataGridViewCellStyle3;
            ordersgridview.Dock = DockStyle.Fill;
            ordersgridview.GridColor = Color.FromArgb(231, 229, 255);
            ordersgridview.Location = new Point(5, 5);
            ordersgridview.Margin = new Padding(5);
            ordersgridview.MultiSelect = false;
            ordersgridview.Name = "ordersgridview";
            ordersgridview.ReadOnly = true;
            ordersgridview.RowHeadersVisible = false;
            ordersgridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ordersgridview.Size = new Size(1101, 601);
            ordersgridview.TabIndex = 6;
            ordersgridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ordersgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            ordersgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ordersgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ordersgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ordersgridview.ThemeStyle.BackColor = Color.White;
            ordersgridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ordersgridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ordersgridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ordersgridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F);
            ordersgridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ordersgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ordersgridview.ThemeStyle.HeaderStyle.Height = 69;
            ordersgridview.ThemeStyle.ReadOnly = true;
            ordersgridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            ordersgridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ordersgridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 15F);
            ordersgridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ordersgridview.ThemeStyle.RowsStyle.Height = 32;
            ordersgridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ordersgridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // orderbtnpanel
            // 
            orderbtnpanel.BackColor = Color.SteelBlue;
            orderbtnpanel.BorderColor = Color.SkyBlue;
            orderbtnpanel.BorderThickness = 2;
            orderbtnpanel.Controls.Add(txtSearch);
            orderbtnpanel.Controls.Add(btndeleteorders);
            orderbtnpanel.Controls.Add(btnaddOrders);
            orderbtnpanel.CustomizableEdges = customizableEdges3;
            orderbtnpanel.Dock = DockStyle.Fill;
            orderbtnpanel.Location = new Point(4, 615);
            orderbtnpanel.Margin = new Padding(4);
            orderbtnpanel.Name = "orderbtnpanel";
            orderbtnpanel.Padding = new Padding(4);
            orderbtnpanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            orderbtnpanel.Size = new Size(1103, 46);
            orderbtnpanel.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Animated = true;
            txtSearch.BackColor = Color.Transparent;
            txtSearch.BorderColor = Color.Yellow;
            txtSearch.BorderRadius = 26;
            txtSearch.BorderThickness = 2;
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.Dock = DockStyle.Right;
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(599, 4);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderForeColor = Color.DimGray;
            txtSearch.PlaceholderText = "Search";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(500, 38);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btndeleteorders
            // 
            btndeleteorders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btndeleteorders.BackColor = Color.Transparent;
            btndeleteorders.BackgroundImage = (Image)resources.GetObject("btndeleteorders.BackgroundImage");
            btndeleteorders.BackgroundImageLayout = ImageLayout.None;
            btndeleteorders.FlatAppearance.BorderSize = 0;
            btndeleteorders.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btndeleteorders.FlatStyle = FlatStyle.Flat;
            btndeleteorders.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndeleteorders.ForeColor = Color.Transparent;
            btndeleteorders.ImageAlign = ContentAlignment.MiddleLeft;
            btndeleteorders.Location = new Point(282, 9);
            btndeleteorders.Margin = new Padding(2);
            btndeleteorders.Name = "btndeleteorders";
            btndeleteorders.Padding = new Padding(2);
            btndeleteorders.Size = new Size(266, 30);
            btndeleteorders.TabIndex = 10;
            btndeleteorders.Text = "      Delete Order";
            btndeleteorders.TextAlign = ContentAlignment.MiddleLeft;
            btndeleteorders.UseVisualStyleBackColor = false;
            btndeleteorders.Click += btndeleteorders_Click;
            // 
            // btnaddOrders
            // 
            btnaddOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnaddOrders.BackColor = Color.Transparent;
            btnaddOrders.BackgroundImage = (Image)resources.GetObject("btnaddOrders.BackgroundImage");
            btnaddOrders.BackgroundImageLayout = ImageLayout.None;
            btnaddOrders.FlatAppearance.BorderSize = 0;
            btnaddOrders.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnaddOrders.FlatStyle = FlatStyle.Flat;
            btnaddOrders.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddOrders.ForeColor = Color.Transparent;
            btnaddOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnaddOrders.Location = new Point(16, 9);
            btnaddOrders.Margin = new Padding(2);
            btnaddOrders.Name = "btnaddOrders";
            btnaddOrders.Padding = new Padding(2);
            btnaddOrders.Size = new Size(266, 30);
            btnaddOrders.TabIndex = 9;
            btnaddOrders.Text = "      Add Order";
            btnaddOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnaddOrders.UseVisualStyleBackColor = false;
            btnaddOrders.Click += btnaddOrders_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(tablelayoutorderspage);
            DoubleBuffered = true;
            Name = "Orders";
            Size = new Size(1111, 665);
            tablelayoutorderspage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ordersgridview).EndInit();
            orderbtnpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablelayoutorderspage;
        private Guna.UI2.WinForms.Guna2DataGridView ordersgridview;
        private Guna.UI2.WinForms.Guna2Panel orderbtnpanel;
        private Button btndeleteorders;
        private Button btnaddOrders;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
