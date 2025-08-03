namespace FactoryManagementSystem.UserControls
{
    partial class Rawmaterials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rawmaterials));
            rawmaterialgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            tablelayoutrawmaterialpage = new TableLayoutPanel();
            rawmaterialbtnpanel = new Guna.UI2.WinForms.Guna2Panel();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnupdaterawmaterials = new Button();
            btndeleterawmaterial = new Button();
            btnaddrawmaterial = new Button();
            ((System.ComponentModel.ISupportInitialize)rawmaterialgridview).BeginInit();
            tablelayoutrawmaterialpage.SuspendLayout();
            rawmaterialbtnpanel.SuspendLayout();
            SuspendLayout();
            // 
            // rawmaterialgridview
            // 
            rawmaterialgridview.AllowUserToAddRows = false;
            rawmaterialgridview.AllowUserToDeleteRows = false;
            rawmaterialgridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            rawmaterialgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            rawmaterialgridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            rawmaterialgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            rawmaterialgridview.ColumnHeadersHeight = 69;
            rawmaterialgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            rawmaterialgridview.DefaultCellStyle = dataGridViewCellStyle3;
            rawmaterialgridview.Dock = DockStyle.Fill;
            rawmaterialgridview.GridColor = Color.FromArgb(231, 229, 255);
            rawmaterialgridview.Location = new Point(5, 5);
            rawmaterialgridview.Margin = new Padding(5);
            rawmaterialgridview.MultiSelect = false;
            rawmaterialgridview.Name = "rawmaterialgridview";
            rawmaterialgridview.ReadOnly = true;
            rawmaterialgridview.RowHeadersVisible = false;
            rawmaterialgridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            rawmaterialgridview.Size = new Size(1101, 601);
            rawmaterialgridview.TabIndex = 0;
            rawmaterialgridview.TabStop = false;
            rawmaterialgridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            rawmaterialgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            rawmaterialgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            rawmaterialgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            rawmaterialgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            rawmaterialgridview.ThemeStyle.BackColor = Color.White;
            rawmaterialgridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            rawmaterialgridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            rawmaterialgridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            rawmaterialgridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F);
            rawmaterialgridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            rawmaterialgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            rawmaterialgridview.ThemeStyle.HeaderStyle.Height = 69;
            rawmaterialgridview.ThemeStyle.ReadOnly = true;
            rawmaterialgridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            rawmaterialgridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            rawmaterialgridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 15F);
            rawmaterialgridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            rawmaterialgridview.ThemeStyle.RowsStyle.Height = 32;
            rawmaterialgridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            rawmaterialgridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // tablelayoutrawmaterialpage
            // 
            tablelayoutrawmaterialpage.ColumnCount = 1;
            tablelayoutrawmaterialpage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablelayoutrawmaterialpage.Controls.Add(rawmaterialgridview, 0, 0);
            tablelayoutrawmaterialpage.Controls.Add(rawmaterialbtnpanel, 0, 1);
            tablelayoutrawmaterialpage.Dock = DockStyle.Fill;
            tablelayoutrawmaterialpage.Location = new Point(0, 0);
            tablelayoutrawmaterialpage.Name = "tablelayoutrawmaterialpage";
            tablelayoutrawmaterialpage.RowCount = 2;
            tablelayoutrawmaterialpage.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tablelayoutrawmaterialpage.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tablelayoutrawmaterialpage.Size = new Size(1111, 665);
            tablelayoutrawmaterialpage.TabIndex = 2;
            // 
            // rawmaterialbtnpanel
            // 
            rawmaterialbtnpanel.BackColor = Color.SteelBlue;
            rawmaterialbtnpanel.BorderColor = Color.SkyBlue;
            rawmaterialbtnpanel.BorderThickness = 2;
            rawmaterialbtnpanel.Controls.Add(txtSearch);
            rawmaterialbtnpanel.Controls.Add(btnupdaterawmaterials);
            rawmaterialbtnpanel.Controls.Add(btndeleterawmaterial);
            rawmaterialbtnpanel.Controls.Add(btnaddrawmaterial);
            rawmaterialbtnpanel.CustomizableEdges = customizableEdges3;
            rawmaterialbtnpanel.Dock = DockStyle.Fill;
            rawmaterialbtnpanel.Location = new Point(4, 615);
            rawmaterialbtnpanel.Margin = new Padding(4);
            rawmaterialbtnpanel.Name = "rawmaterialbtnpanel";
            rawmaterialbtnpanel.Padding = new Padding(4);
            rawmaterialbtnpanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            rawmaterialbtnpanel.Size = new Size(1103, 46);
            rawmaterialbtnpanel.TabIndex = 7;
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
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnupdaterawmaterials
            // 
            btnupdaterawmaterials.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnupdaterawmaterials.BackColor = Color.Transparent;
            btnupdaterawmaterials.BackgroundImage = (Image)resources.GetObject("btnupdaterawmaterials.BackgroundImage");
            btnupdaterawmaterials.BackgroundImageLayout = ImageLayout.None;
            btnupdaterawmaterials.Enabled = false;
            btnupdaterawmaterials.FlatAppearance.BorderSize = 0;
            btnupdaterawmaterials.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnupdaterawmaterials.FlatStyle = FlatStyle.Flat;
            btnupdaterawmaterials.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdaterawmaterials.ForeColor = Color.Transparent;
            btnupdaterawmaterials.ImageAlign = ContentAlignment.MiddleLeft;
            btnupdaterawmaterials.Location = new Point(724, 8);
            btnupdaterawmaterials.Margin = new Padding(2);
            btnupdaterawmaterials.Name = "btnupdaterawmaterials";
            btnupdaterawmaterials.Padding = new Padding(2);
            btnupdaterawmaterials.Size = new Size(350, 30);
            btnupdaterawmaterials.TabIndex = 11;
            btnupdaterawmaterials.Text = "      Update Raw Material";
            btnupdaterawmaterials.TextAlign = ContentAlignment.MiddleLeft;
            btnupdaterawmaterials.UseVisualStyleBackColor = false;
            btnupdaterawmaterials.Visible = false;
            btnupdaterawmaterials.Click += btnupdaterawmaterials_Click;
            // 
            // btndeleterawmaterial
            // 
            btndeleterawmaterial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btndeleterawmaterial.BackColor = Color.Transparent;
            btndeleterawmaterial.BackgroundImage = (Image)resources.GetObject("btndeleterawmaterial.BackgroundImage");
            btndeleterawmaterial.BackgroundImageLayout = ImageLayout.None;
            btndeleterawmaterial.Enabled = false;
            btndeleterawmaterial.FlatAppearance.BorderSize = 0;
            btndeleterawmaterial.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btndeleterawmaterial.FlatStyle = FlatStyle.Flat;
            btndeleterawmaterial.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndeleterawmaterial.ForeColor = Color.Transparent;
            btndeleterawmaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btndeleterawmaterial.Location = new Point(374, 8);
            btndeleterawmaterial.Margin = new Padding(2);
            btndeleterawmaterial.Name = "btndeleterawmaterial";
            btndeleterawmaterial.Padding = new Padding(2);
            btndeleterawmaterial.Size = new Size(350, 30);
            btndeleterawmaterial.TabIndex = 10;
            btndeleterawmaterial.Text = "      Delete Raw Material";
            btndeleterawmaterial.TextAlign = ContentAlignment.MiddleLeft;
            btndeleterawmaterial.UseVisualStyleBackColor = false;
            btndeleterawmaterial.Visible = false;
            btndeleterawmaterial.Click += btndeleterawmaterial_Click;
            // 
            // btnaddrawmaterial
            // 
            btnaddrawmaterial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnaddrawmaterial.BackColor = Color.Transparent;
            btnaddrawmaterial.BackgroundImage = (Image)resources.GetObject("btnaddrawmaterial.BackgroundImage");
            btnaddrawmaterial.BackgroundImageLayout = ImageLayout.None;
            btnaddrawmaterial.FlatAppearance.BorderSize = 0;
            btnaddrawmaterial.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnaddrawmaterial.FlatStyle = FlatStyle.Flat;
            btnaddrawmaterial.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddrawmaterial.ForeColor = Color.Transparent;
            btnaddrawmaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btnaddrawmaterial.Location = new Point(24, 8);
            btnaddrawmaterial.Margin = new Padding(2);
            btnaddrawmaterial.Name = "btnaddrawmaterial";
            btnaddrawmaterial.Padding = new Padding(2);
            btnaddrawmaterial.Size = new Size(350, 30);
            btnaddrawmaterial.TabIndex = 9;
            btnaddrawmaterial.Text = "      Add Raw Material";
            btnaddrawmaterial.TextAlign = ContentAlignment.MiddleLeft;
            btnaddrawmaterial.UseVisualStyleBackColor = false;
            btnaddrawmaterial.Click += btnaddrawmaterial_Click;
            // 
            // Rawmaterials
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(tablelayoutrawmaterialpage);
            Name = "Rawmaterials";
            Size = new Size(1111, 665);
            ((System.ComponentModel.ISupportInitialize)rawmaterialgridview).EndInit();
            tablelayoutrawmaterialpage.ResumeLayout(false);
            rawmaterialbtnpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView rawmaterialgridview;
        private TableLayoutPanel tablelayoutrawmaterialpage;
        private Guna.UI2.WinForms.Guna2Panel rawmaterialbtnpanel;
        private Button btnupdaterawmaterials;
        private Button btndeleterawmaterial;
        private Button btnaddrawmaterial;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
