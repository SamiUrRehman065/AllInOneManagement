namespace FactoryManagementSystem.UserControls.SummaryControls
{
    partial class Summary
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
            StockGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            lblInflow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblOutflow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblNetFlow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTotalOrders = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblheader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblStock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)StockGridView).BeginInit();
            SuspendLayout();
            // 
            // StockGridView
            // 
            StockGridView.AllowUserToAddRows = false;
            StockGridView.AllowUserToDeleteRows = false;
            StockGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            StockGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            StockGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            StockGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            StockGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            StockGridView.ColumnHeadersHeight = 50;
            StockGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            StockGridView.DefaultCellStyle = dataGridViewCellStyle3;
            StockGridView.GridColor = Color.FromArgb(231, 229, 255);
            StockGridView.Location = new Point(466, 214);
            StockGridView.Margin = new Padding(5);
            StockGridView.MultiSelect = false;
            StockGridView.Name = "StockGridView";
            StockGridView.ReadOnly = true;
            StockGridView.RowHeadersVisible = false;
            StockGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            StockGridView.Size = new Size(616, 233);
            StockGridView.TabIndex = 10;
            StockGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            StockGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            StockGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            StockGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            StockGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            StockGridView.ThemeStyle.BackColor = Color.White;
            StockGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            StockGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            StockGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            StockGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F);
            StockGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            StockGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            StockGridView.ThemeStyle.HeaderStyle.Height = 50;
            StockGridView.ThemeStyle.ReadOnly = true;
            StockGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            StockGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            StockGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 15F);
            StockGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            StockGridView.ThemeStyle.RowsStyle.Height = 32;
            StockGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            StockGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblInflow
            // 
            lblInflow.BackColor = Color.Transparent;
            lblInflow.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblInflow.Location = new Point(33, 124);
            lblInflow.Name = "lblInflow";
            lblInflow.Size = new Size(189, 47);
            lblInflow.TabIndex = 11;
            lblInflow.TabStop = false;
            lblInflow.Text = "Total Inflow";
            // 
            // lblOutflow
            // 
            lblOutflow.BackColor = Color.Transparent;
            lblOutflow.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblOutflow.Location = new Point(33, 214);
            lblOutflow.Name = "lblOutflow";
            lblOutflow.Size = new Size(217, 47);
            lblOutflow.TabIndex = 12;
            lblOutflow.TabStop = false;
            lblOutflow.Text = "Total Outflow";
            // 
            // lblNetFlow
            // 
            lblNetFlow.BackColor = Color.Transparent;
            lblNetFlow.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNetFlow.Location = new Point(33, 311);
            lblNetFlow.Name = "lblNetFlow";
            lblNetFlow.Size = new Size(141, 47);
            lblNetFlow.TabIndex = 13;
            lblNetFlow.TabStop = false;
            lblNetFlow.Text = "Net Flow";
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.BackColor = Color.Transparent;
            lblTotalOrders.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalOrders.Location = new Point(33, 406);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(195, 47);
            lblTotalOrders.TabIndex = 14;
            lblTotalOrders.TabStop = false;
            lblTotalOrders.Text = "Total Orders";
            // 
            // lblheader
            // 
            lblheader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblheader.BackColor = Color.Transparent;
            lblheader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblheader.ForeColor = Color.Red;
            lblheader.Location = new Point(410, 32);
            lblheader.Name = "lblheader";
            lblheader.Size = new Size(290, 56);
            lblheader.TabIndex = 15;
            lblheader.TabStop = false;
            lblheader.Text = "Daily Summary";
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStock.Location = new Point(466, 124);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(240, 47);
            lblStock.TabIndex = 16;
            lblStock.TabStop = false;
            lblStock.Text = "Available Stock";
            // 
            // Summary
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(lblStock);
            Controls.Add(lblheader);
            Controls.Add(lblTotalOrders);
            Controls.Add(lblNetFlow);
            Controls.Add(lblOutflow);
            Controls.Add(lblInflow);
            Controls.Add(StockGridView);
            DoubleBuffered = true;
            Name = "Summary";
            Size = new Size(1111, 665);
            ((System.ComponentModel.ISupportInitialize)StockGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView StockGridView;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInflow;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOutflow;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNetFlow;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalOrders;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblheader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStock;
    }
}
