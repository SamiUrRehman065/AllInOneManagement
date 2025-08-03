using FactoryManagementSystem.UserControls.LedgersControls.CrudControlsLedger;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing.Printing;

namespace FactoryManagementSystem.UserControls
{


    public partial class Ledgers : UserControl
    {
        private DataTable OrderData = new();
        private DataTable CustomeroriginalData = new();
        private DataTable LedgerData = new();
        private DataTable OrderClearanceData = new();
        public Ledgers()
        {
            InitializeComponent();

            LoadCustomersAsync().ConfigureAwait(false);
        }

        private async Task LoadCustomersAsync()
        {
            try
            {
                CustomeroriginalData = await DatabaseOperation.GetTableDataAsync("Customer");


                CustomerGridView.DataSource = CustomeroriginalData;
                CustomerGridView.ClearSelection();
                // Set custom column headers
                CustomerGridView.Columns["CustomerID"].HeaderText = "ID";
                CustomerGridView.Columns["Name"].HeaderText = "Name";
                CustomerGridView.Columns["CNIC"].Visible = false;
                CustomerGridView.Columns["PhoneNumber"].HeaderText = "Phone";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CustomerGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CustomerGridView.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(CustomerGridView.SelectedRows[0].Cells["CustomerID"].Value);
                await LoadLedgerAsync(customerId);
            }
        }
        private async Task LoadLedgerAsync(int customerId)
        {
            try
            {
                string condition = $"CustomerID = {customerId}";
                LedgerData = await DatabaseOperation.GetTableDataAsync("Ledger", condition);

                LedgerGridView.DataSource = LedgerData;
                LedgerGridView.ClearSelection();

                // Set custom column headers
                LedgerGridView.Columns["LedgerID"].HeaderText = "Ledger ID";
                LedgerGridView.Columns["CustomerID"].HeaderText = "Customer ID";
                LedgerGridView.Columns["Amount"].HeaderText = "Amount";
                LedgerGridView.Columns["Amount"].DefaultCellStyle.Format = "N0";
                LedgerGridView.Columns["Date"].HeaderText = "Date";


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Ledger: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LedgerGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (LedgerGridView.SelectedRows.Count > 0)
            {
                int ledgerId = Convert.ToInt32(LedgerGridView.SelectedRows[0].Cells["LedgerID"].Value);
                await LoadOrdersAsync(ledgerId);
                await LoadOrdersClearanceLogAsync(ledgerId);
            }
        }
        private async Task LoadOrdersAsync(int ledgerId)
        {
            try
            {
                string condition = $"LedgerID = {ledgerId}";
                OrderData = await DatabaseOperation.GetTableDataAsync("Orders", condition);

                OrderGridView.DataSource = OrderData;
                OrderGridView.ClearSelection();

                // Set custom column headers
                OrderGridView.Columns["OrderID"].Visible = false;
                OrderGridView.Columns["OrderDate"].HeaderText = "Date";
                OrderGridView.Columns["Quantity"].HeaderText = "Quantity";
                OrderGridView.Columns["Quantity"].DefaultCellStyle.Format = "N0";
                OrderGridView.Columns["UnitPrice"].HeaderText = "Unit Price";
                OrderGridView.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";
                OrderGridView.Columns["TotalPrice"].HeaderText = "Total Price";
                OrderGridView.Columns["TotalPrice"].DefaultCellStyle.Format = "N0"; // 2 decimal places
                OrderGridView.Columns["Total SqFeet"].DefaultCellStyle.Format = "N0"; // 2 decimal places
                OrderGridView.Columns["Description"].HeaderText = "Description";
                OrderGridView.Columns["Address"].HeaderText = "Address";
                OrderGridView.Columns["CustomerName"].HeaderText = "Name";
                OrderGridView.Columns["CustomerCNIC"].HeaderText = "CNIC";
                OrderGridView.Columns["CustomerPhone"].HeaderText = "Phone";
                OrderGridView.Columns["PaidAmount"].HeaderText = "Paid Amount";
                OrderGridView.Columns["PaidAmount"].DefaultCellStyle.Format = "N0";
                OrderGridView.Columns["RemainingBalance"].HeaderText = "Remaining Balance";
                OrderGridView.Columns["RemainingBalance"].DefaultCellStyle.Format = "N0";
                OrderGridView.Columns["LedgerID"].Visible = false;
                OrderGridView.Columns["CustomerName"].Visible = false;
                OrderGridView.Columns["CustomerCNIC"].Visible = false;
                OrderGridView.Columns["CustomerPhone"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LoadOrdersClearanceLogAsync(int ledgerId)
        {
            try
            {
                string condition = $"LedgerID = {ledgerId}";
                OrderClearanceData = await DatabaseOperation.GetTableDataAsync("LedgerClearanceLog", condition);

                LedgerClearanceGridview.DataSource = OrderClearanceData;
                LedgerClearanceGridview.ClearSelection();
                LedgerClearanceGridview.Columns["ClearedAmount"].HeaderText = "Paid Amount";
                LedgerClearanceGridview.Columns["ClearedAmount"].DefaultCellStyle.Format = "N0";
                LedgerClearanceGridview.Columns["RemainingBalance"].DefaultCellStyle.Format = "N0";
                LedgerClearanceGridview.Columns["RemainingBalance"].HeaderText = "Remaining Balance";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Ledger Clearance Data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnClearLedger_Click(object sender, EventArgs e)
        {
            if (CustomerGridView.SelectedRows.Count > 0)
            {
                string? Name = CustomerGridView.SelectedRows[0].Cells["Name"].Value.ToString();

                if (LedgerGridView.SelectedRows.Count > 0)
                {
                    int ledgerId = Convert.ToInt32(LedgerGridView.SelectedRows[0].Cells["LedgerID"].Value);
                    decimal? Amount = Convert.ToDecimal(LedgerGridView.SelectedRows[0].Cells["Amount"].Value);

                    Popup popup = new Popup(new UpdateLedgerControl(ledgerId, Amount, Name));
                    popup.ShowDialog();
                    await LoadCustomersAsync();
                }
                else
                {
                    MessageBox.Show("Please select a ledger to clear", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("Please select a Customer Also to clear", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int currentOrderRow = 0;
        private int currentClearanceRow = 0;



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            if (CustomerGridView.SelectedRows.Count == 0)
                return;

            // Fonts & Brushes
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 12, FontStyle.Bold);
            Font contentFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            Pen separatorPen = new Pen(Color.Black, 2);
            Pen dashedPen = new Pen(Color.Black, 1);
            dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            int margin = 50;
            int x = margin;
            int y = margin;
            int lineSpacing = 30;
            int col1 = x;
            int col2 = x + 100;
            int col3 = x + 220;
            int col4 = x + 320;
            int col5 = x + 390;
            int col6 = x + 430;
            int col7 = x + 500;
            int col8 = x + 600;
            int pageHeight = e.MarginBounds.Height - 50;
            int pageBottom = e.PageBounds.Height - 50;
            string logoPath = Path.Combine(Application.StartupPath, "Images", "Logo.png");
            if (File.Exists(logoPath))
            {
                Image logo = Image.FromFile(logoPath);

                // Define max dimensions for logo
                int maxWidth = 250, maxHeight = 150;
                float ratio = Math.Min((float)maxWidth / logo.Width, (float)maxHeight / logo.Height);

                // Calculate scaled width and height
                int logoWidth = (int)(logo.Width * ratio);
                int logoHeight = (int)(logo.Height * ratio);

                // Center the logo on the page
                int centerX = (e.PageBounds.Width - logoWidth) / 2;

                // Draw the logo
                e.Graphics.DrawImage(logo, new Rectangle(centerX, y, logoWidth, logoHeight));

                // Adjust Y position for next elements
                y += logoHeight + 20;
            }

            // Draw Header (Customer Details)
            e.Graphics.DrawString("Customer Details", headerFont, brush, x, y);
            y += lineSpacing;
            e.Graphics.DrawString($"Name: {CustomerGridView.SelectedRows[0].Cells["Name"].Value?.ToString() ?? "N/A"}", subHeaderFont, brush, x, y);
            y += lineSpacing;
            e.Graphics.DrawString($"CNIC: {CustomerGridView.SelectedRows[0].Cells["CNIC"].Value?.ToString() ?? "N/A"}", subHeaderFont, brush, x, y);
            y += lineSpacing;
            e.Graphics.DrawString($"Phone: {CustomerGridView.SelectedRows[0].Cells["PhoneNumber"].Value?.ToString() ?? "N/A"}", subHeaderFont, brush, x, y);
            y += lineSpacing * 2;

            // Orders Header
            e.Graphics.DrawString("Order Records", headerFont, brush, x, y);
            y += lineSpacing + 5;
            e.Graphics.DrawLine(separatorPen, x, y, e.PageBounds.Width - margin, y);
            y += 10;

            // Column Headers for Orders
            e.Graphics.DrawString("Date", contentFont, brush, col1, y);
            e.Graphics.DrawString("Particulars", contentFont, brush, col2, y);
            e.Graphics.DrawString("City", contentFont, brush, col3, y);
            e.Graphics.DrawString("SQ Foot", contentFont, brush, col4, y);
            e.Graphics.DrawString("Rate", contentFont, brush, col5, y);
            e.Graphics.DrawString("Total", contentFont, brush, col6, y);
            e.Graphics.DrawString("Paid Amount", contentFont, brush, col7, y);
            e.Graphics.DrawString("Remaining Balance", contentFont, brush, col8, y);
            y += lineSpacing;
            e.Graphics.DrawLine(separatorPen, x, y, e.PageBounds.Width - margin, y);
            y += 10;
            // Filter records within selected date range
            DateTime startDate = StartDatePicker.Value.Date;
            DateTime endDate = EndDatePicker.Value.Date;
            List<PrintRecord> printRecords = new List<PrintRecord>();

            // Collect Order Data
            foreach (DataGridViewRow row in OrderGridView.Rows)
            {
                if (row.IsNewRow) continue;
                DateTime orderDateTime = DateTime.TryParse(row.Cells["OrderDate"].Value?.ToString(), out DateTime orderDate)
                        ? orderDate : DateTime.MinValue;
                if (orderDateTime >= startDate && orderDateTime <= endDate) // Date filtering
                {
                    printRecords.Add(new PrintRecord
                    {
                        Date = orderDateTime,
                        Particulars = row.Cells["Product"].Value?.ToString() ?? "-",
                        City = row.Cells["Address"].Value?.ToString() ?? "-",
                        SqFoot = FormatNumber(row.Cells["Total SqFeet"].Value),
                        Rate = FormatNumber(row.Cells["UnitPrice"].Value),
                        Total = FormatNumber(row.Cells["TotalPrice"].Value),
                        PaidAmount = FormatNumber(row.Cells["PaidAmount"].Value),
                        RemainingBalance = FormatNumber(row.Cells["RemainingBalance"].Value)
                    });
                }
            }

            // Collect Clearance Data
            foreach (DataGridViewRow row in LedgerClearanceGridview.Rows)
            {
                if (row.IsNewRow) continue;
                DateTime clearanceDateTime = DateTime.TryParse(row.Cells["ClearanceDate"].Value?.ToString(), out DateTime clearanceDate)
                            ? clearanceDate : DateTime.MinValue;
                if (clearanceDateTime >= startDate && clearanceDateTime <= endDate) // Date filtering
                {
                    printRecords.Add(new PrintRecord
                    {
                        Date = clearanceDateTime, // Include time component
                        Particulars = row.Cells["Description"].Value?.ToString() ?? "-",
                        City = "-",
                        SqFoot = "-",
                        Rate = "-",
                        Total = "-",
                        PaidAmount = FormatNumber(row.Cells["ClearedAmount"].Value),
                        RemainingBalance = FormatNumber(row.Cells["RemainingBalance"].Value)
                    });
                }
            }


            //Sort records by DateTime(to maintain correct sequence)
            printRecords = printRecords.OrderBy(r => r.Date).ToList();
            foreach (var record in printRecords)
            {
                e.Graphics.DrawString(record.Date == DateTime.MinValue ? "-" : record.Date.ToString("dd-MM-yyyy"), contentFont, brush, col1, y);
                e.Graphics.DrawString(record.Particulars, contentFont, brush, col2, y);
                e.Graphics.DrawString(record.City, contentFont, brush, col3, y);
                e.Graphics.DrawString(record.SqFoot, contentFont, brush, col4, y);
                e.Graphics.DrawString(record.Rate, contentFont, brush, col5, y);
                e.Graphics.DrawString(record.Total, contentFont, brush, col6, y);
                e.Graphics.DrawString(record.PaidAmount, contentFont, brush, col7, y);
                e.Graphics.DrawString(record.RemainingBalance, contentFont, brush, col8, y);

                y += lineSpacing;

                if (y > pageHeight) // Page overflow
                {
                    DrawFooter(e, margin, pageBottom, subHeaderFont, brush);
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;

        }

        private void PrintRecordbtn_Click(object sender, EventArgs e)
        {
            if (CustomerGridView.SelectedRows.Count > 0)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Please select a Customer to print details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DrawFooter(PrintPageEventArgs e, int margin, int pageBottom, Font subHeaderFont, Brush brush)
        {
            e.Graphics.DrawString("Shop Contact: 03333974999 , 03073918061 | Email: arifbehan786@gmail.com",
                                  subHeaderFont, brush, new PointF(margin, pageBottom - 40));

            e.Graphics.DrawString("Larkana, Shikarpur Road Main, Bypass Garhi Yaseen",
                                  subHeaderFont, brush, new PointF(margin, pageBottom - 20));
        }

        private string? FormatNumber(object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                return "-"; // Handle null or empty values

            if (decimal.TryParse(value.ToString(), out decimal number))
                return number.ToString("0.##"); // Formats without unnecessary zeros

            return value.ToString(); // If not a number, return as is
        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (LedgerClearanceGridview.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a clearance entry to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int clearanceLogId = Convert.ToInt32(LedgerClearanceGridview.SelectedRows[0].Cells["ClearanceID"].Value);
                int ledgerId = Convert.ToInt32(LedgerClearanceGridview.SelectedRows[0].Cells["LedgerID"].Value);
                string? CustomerName = CustomerGridView.SelectedRows[0].Cells["Name"].Value.ToString();

                // Confirmation before deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this clearance entry?",
                                                      "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(DatabaseOperation.GetConnectionString()))
                    {
                        await conn.OpenAsync();
                        using (SqlCommand cmd = new SqlCommand("DeleteClientLedgerClearance", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ClearanceID", clearanceLogId);
                            cmd.Parameters.AddWithValue("@LedgerID", ledgerId);
                            cmd.Parameters.AddWithValue("@ClientName ", CustomerName);

                            int affectedRows = await cmd.ExecuteNonQueryAsync();

                            if (affectedRows > 0)
                            {
                                await LoadCustomersAsync();
                                await LoadLedgerAsync(ledgerId);
                                await LoadOrdersClearanceLogAsync(ledgerId);

                                MessageBox.Show("Clearance reversal successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No matching clearance entry found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting clearance entry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
    class PrintRecord
    {
        public DateTime Date { get; set; }
        public string? Particulars { get; set; }
        public string? City { get; set; }
        public string? SqFoot { get; set; }
        public string? Rate { get; set; }
        public string? Total { get; set; }
        public string? PaidAmount { get; set; }
        public string? RemainingBalance { get; set; }
    }
}
