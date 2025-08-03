namespace FactoryManagementSystem.UserControls
{
    partial class Production
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Production));
            productiongridview = new Guna.UI2.WinForms.Guna2DataGridView();
            tablelayoutproductionpage = new TableLayoutPanel();
            productionbtnpanel = new Guna.UI2.WinForms.Guna2Panel();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnupdateproduction = new Button();
            btndeleteproduction = new Button();
            btnaddproduction = new Button();
            ((System.ComponentModel.ISupportInitialize)productiongridview).BeginInit();
            tablelayoutproductionpage.SuspendLayout();
            productionbtnpanel.SuspendLayout();
            SuspendLayout();
            // 
            // productiongridview
            // 
            productiongridview.AllowUserToAddRows = false;
            productiongridview.AllowUserToDeleteRows = false;
            productiongridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            productiongridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            productiongridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productiongridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            productiongridview.ColumnHeadersHeight = 50;
            productiongridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            productiongridview.DefaultCellStyle = dataGridViewCellStyle3;
            productiongridview.Dock = DockStyle.Fill;
            productiongridview.GridColor = Color.FromArgb(231, 229, 255);
            productiongridview.Location = new Point(5, 5);
            productiongridview.Margin = new Padding(5);
            productiongridview.MultiSelect = false;
            productiongridview.Name = "productiongridview";
            productiongridview.ReadOnly = true;
            productiongridview.RowHeadersVisible = false;
            productiongridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            productiongridview.Size = new Size(1101, 601);
            productiongridview.TabIndex = 6;
            productiongridview.TabStop = false;
            productiongridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            productiongridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            productiongridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            productiongridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            productiongridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            productiongridview.ThemeStyle.BackColor = Color.White;
            productiongridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            productiongridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            productiongridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            productiongridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F);
            productiongridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            productiongridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            productiongridview.ThemeStyle.HeaderStyle.Height = 50;
            productiongridview.ThemeStyle.ReadOnly = true;
            productiongridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            productiongridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productiongridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 15F);
            productiongridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            productiongridview.ThemeStyle.RowsStyle.Height = 32;
            productiongridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            productiongridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // tablelayoutproductionpage
            // 
            tablelayoutproductionpage.ColumnCount = 1;
            tablelayoutproductionpage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablelayoutproductionpage.Controls.Add(productiongridview, 0, 0);
            tablelayoutproductionpage.Controls.Add(productionbtnpanel, 0, 1);
            tablelayoutproductionpage.Dock = DockStyle.Fill;
            tablelayoutproductionpage.Location = new Point(0, 0);
            tablelayoutproductionpage.Name = "tablelayoutproductionpage";
            tablelayoutproductionpage.RowCount = 2;
            tablelayoutproductionpage.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tablelayoutproductionpage.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tablelayoutproductionpage.Size = new Size(1111, 665);
            tablelayoutproductionpage.TabIndex = 3;
            // 
            // productionbtnpanel
            // 
            productionbtnpanel.BackColor = Color.SteelBlue;
            productionbtnpanel.BorderColor = Color.SkyBlue;
            productionbtnpanel.BorderThickness = 2;
            productionbtnpanel.Controls.Add(txtSearch);
            productionbtnpanel.Controls.Add(btnupdateproduction);
            productionbtnpanel.Controls.Add(btndeleteproduction);
            productionbtnpanel.Controls.Add(btnaddproduction);
            productionbtnpanel.CustomizableEdges = customizableEdges3;
            productionbtnpanel.Dock = DockStyle.Fill;
            productionbtnpanel.Location = new Point(4, 615);
            productionbtnpanel.Margin = new Padding(4);
            productionbtnpanel.Name = "productionbtnpanel";
            productionbtnpanel.Padding = new Padding(4);
            productionbtnpanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            productionbtnpanel.Size = new Size(1103, 46);
            productionbtnpanel.TabIndex = 7;
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
            // btnupdateproduction
            // 
            btnupdateproduction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnupdateproduction.BackColor = Color.Transparent;
            btnupdateproduction.BackgroundImage = (Image)resources.GetObject("btnupdateproduction.BackgroundImage");
            btnupdateproduction.BackgroundImageLayout = ImageLayout.None;
            btnupdateproduction.Enabled = false;
            btnupdateproduction.FlatAppearance.BorderSize = 0;
            btnupdateproduction.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnupdateproduction.FlatStyle = FlatStyle.Flat;
            btnupdateproduction.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdateproduction.ForeColor = Color.Transparent;
            btnupdateproduction.ImageAlign = ContentAlignment.MiddleLeft;
            btnupdateproduction.Location = new Point(728, 8);
            btnupdateproduction.Margin = new Padding(2);
            btnupdateproduction.Name = "btnupdateproduction";
            btnupdateproduction.Padding = new Padding(2);
            btnupdateproduction.Size = new Size(318, 30);
            btnupdateproduction.TabIndex = 11;
            btnupdateproduction.Text = "      Update Production";
            btnupdateproduction.TextAlign = ContentAlignment.MiddleLeft;
            btnupdateproduction.UseVisualStyleBackColor = false;
            btnupdateproduction.Visible = false;
            btnupdateproduction.Click += btnupdateproduction_Click;
            // 
            // btndeleteproduction
            // 
            btndeleteproduction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btndeleteproduction.BackColor = Color.Transparent;
            btndeleteproduction.BackgroundImage = (Image)resources.GetObject("btndeleteproduction.BackgroundImage");
            btndeleteproduction.BackgroundImageLayout = ImageLayout.None;
            btndeleteproduction.FlatAppearance.BorderSize = 0;
            btndeleteproduction.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btndeleteproduction.FlatStyle = FlatStyle.Flat;
            btndeleteproduction.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndeleteproduction.ForeColor = Color.Transparent;
            btndeleteproduction.ImageAlign = ContentAlignment.MiddleLeft;
            btndeleteproduction.Location = new Point(378, 8);
            btndeleteproduction.Margin = new Padding(2);
            btndeleteproduction.Name = "btndeleteproduction";
            btndeleteproduction.Padding = new Padding(2);
            btndeleteproduction.Size = new Size(318, 30);
            btndeleteproduction.TabIndex = 10;
            btndeleteproduction.Text = "      Delete Production";
            btndeleteproduction.TextAlign = ContentAlignment.MiddleLeft;
            btndeleteproduction.UseVisualStyleBackColor = false;
            btndeleteproduction.Click += btndeleteproduction_Click;
            // 
            // btnaddproduction
            // 
            btnaddproduction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnaddproduction.BackColor = Color.Transparent;
            btnaddproduction.BackgroundImage = (Image)resources.GetObject("btnaddproduction.BackgroundImage");
            btnaddproduction.BackgroundImageLayout = ImageLayout.None;
            btnaddproduction.FlatAppearance.BorderSize = 0;
            btnaddproduction.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnaddproduction.FlatStyle = FlatStyle.Flat;
            btnaddproduction.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddproduction.ForeColor = Color.Transparent;
            btnaddproduction.ImageAlign = ContentAlignment.MiddleLeft;
            btnaddproduction.Location = new Point(28, 8);
            btnaddproduction.Margin = new Padding(2);
            btnaddproduction.Name = "btnaddproduction";
            btnaddproduction.Padding = new Padding(2);
            btnaddproduction.Size = new Size(318, 30);
            btnaddproduction.TabIndex = 9;
            btnaddproduction.Text = "      Add Production";
            btnaddproduction.TextAlign = ContentAlignment.MiddleLeft;
            btnaddproduction.UseVisualStyleBackColor = false;
            btnaddproduction.Click += btnaddproduction_Click;
            // 
            // Production
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(tablelayoutproductionpage);
            Name = "Production";
            Size = new Size(1111, 665);
            ((System.ComponentModel.ISupportInitialize)productiongridview).EndInit();
            tablelayoutproductionpage.ResumeLayout(false);
            productionbtnpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView productiongridview;
        private TableLayoutPanel tablelayoutproductionpage;
        private Guna.UI2.WinForms.Guna2Panel productionbtnpanel;
        private Button btnupdateproduction;
        private Button btndeleteproduction;
        private Button btnaddproduction;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
