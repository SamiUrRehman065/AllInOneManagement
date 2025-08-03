using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;


namespace FactoryManagementSystem.UserControls.OrdersControls.CrudControlsOrder
{
    public partial class AddOrderControl : UserControl
    {
        private DataTable StockoriginalData = new();
        private DataTable CustomeroriginalData = new();
        private readonly string Type;

        private string? _customerName;
        private decimal _totalSqFeet;
        private decimal _unitPrice;
        private string? _address;
        private DateTime _orderDate;
        private string? _productName;
        private string? _driverName;
        private string? _driverPhone;
        private string? _vehicleDetails;
        private int? CustomerId = null;

        public AddOrderControl(String Type)
        {
            InitializeComponent();

            DatePicker.Value = DateTime.Now;
            LoadStockAsync().ConfigureAwait(false);
            this.Type = Type;
            if (Type == "Cash")
            {
                CustomersGridView.Visible = false;
                lblCustomerHeader.Visible = false;
                NewLeadgweCheckBox.Visible = false;
                horizontalSeparator3.Visible = false;
                Stockgridview.Height = 690;
                txtPayAmount.Visible = false;
                btnAdd.Location = new Point(794, 800);
            }
            else
            {
                LoadCustomersAsync().ConfigureAwait(false);
                CustomersGridView.Visible = true;
                lblCustomerHeader.Visible = true;
                NewLeadgweCheckBox.Visible = true;
                txtCName.ReadOnly = true;

                TxtPhoneNo.ReadOnly = true;
                txtCName.Enabled = false;

                TxtPhoneNo.Enabled = false;

            }



        }

        private async Task LoadStockAsync()
        {
            try
            {
                StockoriginalData = await DatabaseOperation.GetTableDataAsync("Stock");
                Stockgridview.DataSource = StockoriginalData;
                Stockgridview.ClearSelection();
                Stockgridview.Columns["StockID"].HeaderText = "ID";
                Stockgridview.Columns["ProductName"].HeaderText = "Name";
                Stockgridview.Columns["Quantity"].HeaderText = "Quantity";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadCustomersAsync()
        {
            try
            {
                CustomeroriginalData = await DatabaseOperation.GetTableDataAsync("Customer");
                // Select only required columns (CustomerID, Name, CNIC)

                CustomersGridView.DataSource = CustomeroriginalData;
                CustomersGridView.ClearSelection();
                // Set custom column headers
                CustomersGridView.Columns["CustomerID"].HeaderText = "ID";
                CustomersGridView.Columns["Name"].HeaderText = "Name";
                CustomersGridView.Columns["CNIC"].HeaderText = "CNIC";
                CustomersGridView.Columns["PhoneNumber"].HeaderText = "Phone";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Stockgridview_SelectionChanged(object sender, EventArgs e)
        {
            if (Stockgridview.CurrentRow != null && Stockgridview.CurrentRow.Cells["ProductName"].Value != null)
            {
                txtProductName.Text = Stockgridview.CurrentRow.Cells["ProductName"].Value.ToString();
            }
        }

        private void NewLeadgweCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If checked, hide and disable the CustomersGridView and header
            if (NewLeadgweCheckBox.Checked)
            {
                CustomersGridView.Visible = false;

                CustomersGridView.Enabled = false;
                lblCustomerHeader.Visible = false;
                horizontalSeparator3.Visible = false;
                Stockgridview.Height = 690;
                txtCName.ReadOnly = false;

                TxtPhoneNo.ReadOnly = false;
                txtCName.Text = string.Empty;

                TxtPhoneNo.Text = string.Empty;
                txtCName.Enabled = true;

                TxtPhoneNo.Enabled = true;
                CustomerId = null;
            }
            else
            {
                txtCName.ReadOnly = true;

                TxtPhoneNo.ReadOnly = true;
                txtCName.Enabled = false;

                TxtPhoneNo.Enabled = false;
                CustomersGridView.Visible = true;
                CustomersGridView.Enabled = true;
                lblCustomerHeader.Visible = true;
                horizontalSeparator3.Visible = true;
                Stockgridview.Height = 259;
            }
        }

        private void CustomersGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CustomersGridView.CurrentRow != null)
            {
                txtCName.Text = CustomersGridView.CurrentRow.Cells["Name"].Value.ToString();

                TxtPhoneNo.Text = CustomersGridView.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                CustomerId = Convert.ToInt32(CustomersGridView.CurrentRow.Cells["CustomerID"].Value);

            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (Type == "Cash")
            {
                if (ValidateOrder(
                                  out string errorMessage,
                                  out string? customerName,
                                  out string? cnic,
                                  out string? phone,
                                  out decimal quantityPerSqFeet,
                                  out decimal totalSqFeet,
                                  out decimal totalQuantity,
                                  out decimal unitPrice,
                                  out string? address,
                                  out string? description,
                                  out string? productName,
                                  out DateTime OrderDate,
                                  out int StockId,
                                  out string? driverName,
                                  out string? driverPhone,
                                  out string? vehicleDetails))
                {
                    await AddCashOrder(customerName, cnic, phone, totalQuantity, unitPrice, address, description, OrderDate, StockId, productName, totalSqFeet, driverName, driverPhone, vehicleDetails);
                }
                else
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (ValidateOrder(
                                 out string errorMessage,
                                 out string? customerName,
                                 out string? cnic,
                                 out string? phone,
                                 out decimal quantityPerSqFeet,
                                 out decimal totalSqFeet,
                                 out decimal totalQuantity,
                                 out decimal unitPrice,
                                 out string? address,
                                 out string? description,
                                 out string? productName,
                                 out DateTime OrderDate,
                                 out int StockId,
                                 out string? driverName,
                                 out string? driverPhone,
                                 out string? vehicleDetails))
                {
                    int PaidAmount = txtPayAmount.Text == "" ? 0 : Convert.ToInt32(txtPayAmount.Text);
                    await AddCreditOrder(customerName, cnic, phone, totalQuantity, unitPrice, address, description, OrderDate, StockId, productName, totalSqFeet, driverName, driverPhone, vehicleDetails, CustomerId, PaidAmount);
                }
                else
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task AddCashOrder(string? customerName, string? cnic, string? phone, decimal totalQuantity, decimal unitPrice, string? address, string? description, DateTime OrderDate, int StockId, string? productName, decimal totalSqFeet, string? DriverName, string? DriverPhone, string? VehicleDetails)
        {
            try
            {
                btnAdd.Enabled = false; // Disable button to prevent multiple clicks
                                        // Open connection asynchronously
                using (SqlConnection conn = new(DatabaseOperation.GetConnectionString()))
                {
                    await conn.OpenAsync(); // Open connection asynchronously

                    using (SqlCommand cmd = new("InsertCashOrder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Pass parameters to stored procedure
                        cmd.Parameters.AddWithValue("@OrderDate", OrderDate);
                        cmd.Parameters.AddWithValue("@Quantity", totalQuantity);
                        cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@CustomerName", customerName);
                        cmd.Parameters.AddWithValue("@CustomerCNIC", cnic);
                        cmd.Parameters.AddWithValue("@CustomerPhone", phone);
                        cmd.Parameters.AddWithValue("@StockID", StockId);
                        cmd.Parameters.AddWithValue("@productName", productName);
                        cmd.Parameters.AddWithValue("@TotalSquareFeet", totalSqFeet);

                        // Output parameter for affected rows
                        SqlParameter outputAffectedRows = new("@RowsAffected", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputAffectedRows);

                        // Execute the procedure asynchronously
                        int result = await cmd.ExecuteNonQueryAsync();

                        // Retrieve the affected rows count from the output parameter
                        int affectedRows = (int)outputAffectedRows.Value;

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Order Added And CashFlow and stock updated successfully.");
                            // Clear fields after successful operation
                            printInvoice(customerName, totalSqFeet, unitPrice, address, OrderDate, productName, DriverName, DriverPhone, VehicleDetails);
                            ClearFields();
                            await LoadStockAsync();
                        }
                        else
                        {
                            MessageBox.Show("Order Not Placed SucessFuly. Please check your input or the data.");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and show appropriate message
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAdd.Enabled = true; // Enable button after operation completes
            }
        }
        private async Task AddCreditOrder(string? customerName, string? cnic, string? phone, decimal totalQuantity, decimal unitPrice, string? address, string? description, DateTime OrderDate, int StockId, string? productName, decimal totalSqFeet, string? DriverName, string? DriverPhone, string? VehicleDetails, int? CustomerId, int PaidAmount)
        {
            try
            {
                btnAdd.Enabled = false; // Disable button to prevent multiple clicks
                                        // Open connection asynchronously
                using (SqlConnection conn = new(DatabaseOperation.GetConnectionString()))
                {
                    await conn.OpenAsync(); // Open connection asynchronously

                    using (SqlCommand cmd = new("InsertCreditOrder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Pass parameters to stored procedure
                        cmd.Parameters.AddWithValue("@CustomerID", CustomerId);
                        cmd.Parameters.AddWithValue("@CustomerName", customerName);
                        cmd.Parameters.AddWithValue("@CNIC", cnic);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Quantity", totalQuantity);
                        cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        cmd.Parameters.AddWithValue("@OrderDate", OrderDate);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@StockID", StockId);
                        cmd.Parameters.AddWithValue("@productName", productName);
                        cmd.Parameters.AddWithValue("@TotalSquareFeet", totalSqFeet);
                        cmd.Parameters.AddWithValue("@PaidAmount", PaidAmount);

                        // Execute the procedure asynchronously & get affected rows
                        object? result = await cmd.ExecuteScalarAsync();
                        int affectedRows = (result != null) ? Convert.ToInt32(result) : 0;

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Order Added And Ledger, CashFlow and stock updated successfully.");
                            printInvoice(customerName, totalSqFeet, unitPrice, address, OrderDate, productName, DriverName, DriverPhone, VehicleDetails);
                            // Clear fields after successful operation

                            ClearFields();
                            await LoadStockAsync();
                            await LoadCustomersAsync();
                        }
                        else
                        {
                            MessageBox.Show("Order Not Placed SucessFuly. Please check your input or the data.");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and show appropriate message
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAdd.Enabled = true; // Enable button after operation completes
            }
        }

        private bool ValidateOrder(
                                    out string errorMessage,
                                    out string customerName,
                                    out string cnic,
                                    out string phone,
                                    out decimal quantityPerSqFeet,
                                    out decimal totalSqFeet,
                                    out decimal totalQuantity,
                                    out decimal unitPrice,
                                    out string address,
                                    out string description,
                                    out string productName,
                                    out DateTime OrderDate,
                                    out int StockId,
                                    out string driverName,
                                    out string driverPhone,
                                    out string vehicleDetails)

        {
            errorMessage = "";



            // Initialize out parameters with default values
            customerName = txtCName.Text.Trim();
            cnic = "";
            phone = TxtPhoneNo.Text.Trim();
            address = txtAddress.Text.Trim();
            description = txtdescription.Text.Trim();
            productName = txtProductName.Text.Trim();
            OrderDate = DatePicker.Value;
            driverName = txtDriverName.Text.Trim();
            driverPhone = txtDriverPhone.Text.Trim();
            vehicleDetails = txtDriverCar.Text.Trim();
            StockId = 0;




            // Validate Customer Name
            if (string.IsNullOrWhiteSpace(customerName))
                errorMessage += "Customer Name is required.\n";



            // Validate Phone Number
            if (string.IsNullOrWhiteSpace(phone))
                errorMessage += "Phone Number is required.\n";
            // Validate Priduct  Name
            if (string.IsNullOrWhiteSpace(productName))
                errorMessage += "Plz Select A Product From List.\n";

            // Validate Quantity Per Sq Feet
            if (!decimal.TryParse(txtQPerSquareFeet.Text, out quantityPerSqFeet) || quantityPerSqFeet <= 0)
                errorMessage += "Valid Quantity Per Sq Feet is required.\n";

            // Validate Total Sq Feet
            if (!decimal.TryParse(txtTotalSqFeet.Text, out totalSqFeet) || totalSqFeet <= 0)
                errorMessage += "Valid Total Sq Feet is required.\n";

            // Validate Unit Price
            if (!decimal.TryParse(txtPriceperunit.Text, out unitPrice) || unitPrice <= 0)
                errorMessage += "Valid Unit Price is required.\n";

            // Calculate Total Quantity & Total Price
            totalQuantity = quantityPerSqFeet * totalSqFeet;
            // ✅ Check Stock Availability in Grid View
            bool stockFound = false;
            int availableStock = 0;

            foreach (DataGridViewRow row in Stockgridview.Rows)
            {
                if (row.Cells["ProductName"].Value != null && row.Cells["ProductName"].Value.ToString() == productName)
                {
                    stockFound = true;
                    availableStock = Convert.ToInt32(row.Cells["Quantity"].Value);
                    StockId = Convert.ToInt32(row.Cells["StockID"].Value);
                    break;
                }
            }

            if (!stockFound)
            {
                errorMessage += "Selected product not found in stock.\n";
            }
            else if (totalQuantity > availableStock)
            {
                errorMessage += $"Insufficient stock! Available: {availableStock}, Required: {totalQuantity}\n";
            }

            // Validate Address
            if (string.IsNullOrWhiteSpace(address))
                errorMessage += "Address is required.\n";

            // Validate Description
            if (string.IsNullOrWhiteSpace(description))
                errorMessage += "Description is required.\n";
            // Validate Driver Name
            if (string.IsNullOrWhiteSpace(driverName))
                errorMessage += "Driver Name is required.\n";

            // Validate Driver Phone No.
            if (string.IsNullOrWhiteSpace(driverPhone))
                errorMessage += "Driver Phone No. is required.\n";

            // Validate Vehicle Details
            if (string.IsNullOrWhiteSpace(vehicleDetails))
                errorMessage += "Vehicle Details are required.\n";

            // Return validation status
            return string.IsNullOrEmpty(errorMessage);
        }





        private void txtQPerSquareFeet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true; // Cancel the input if it's not a digit, decimal point, or Backspace
            }
            if (e.KeyChar == '.' && txtQPerSquareFeet.Text.Contains('.'))
            {
                e.Handled = true; // Cancel the input if there is already a decimal point
            }
        }

        private void txtTotalSqFeet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true; // Cancel the input if it's not a digit, decimal point, or Backspace
            }
            if (e.KeyChar == '.' && txtTotalSqFeet.Text.Contains('.'))
            {
                e.Handled = true; // Cancel the input if there is already a decimal point
            }
        }

        private void txtPriceperunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true; // Cancel the input if it's not a digit, decimal point, or Backspace
            }
            if (e.KeyChar == '.' && txtPriceperunit.Text.Contains('.'))
            {
                e.Handled = true; // Cancel the input if there is already a decimal point
            }
        }

        private void ClearFields()
        {
            txtCName.Text = string.Empty;

            txtAddress.Text = string.Empty;
            TxtPhoneNo.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtQPerSquareFeet.Text = string.Empty;
            txtTotalSqFeet.Text = string.Empty;
            txtPriceperunit.Text = string.Empty;
            txtdescription.Text = string.Empty;
            DatePicker.Value = DateTime.Now;

        }
        private void printInvoice(string? customerName, decimal totalSqFeet, decimal unitPrice, string? address, DateTime OrderDate, string? productName, string? DriverName, string? DriverPhone, string? VehicleDetails)
        {
            // Store data in class-level variables
            _customerName = customerName;
            _totalSqFeet = totalSqFeet;
            _unitPrice = unitPrice;
            _address = address;
            _orderDate = OrderDate;
            _productName = productName;
            _driverName = DriverName;
            _driverPhone = DriverPhone;
            _vehicleDetails = VehicleDetails;
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.Landscape = false;  // Ensure Portrait Mode
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
            printDocument1.Print();




        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics? g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighSpeed;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            using (Font titleFont = new("Arial", 14, FontStyle.Bold))
            using (Font normalFont = new("Arial", 10))
            using (Font boldFont = new("Arial", 10, FontStyle.Bold))
            {
                Brush brush = Brushes.Black;

                int pageWidth = e.PageBounds.Width;
                int pageHeight = e.PageBounds.Height;
                int xMargin = 15, yStart = 40, y = yStart;
                bool isA4 = (pageWidth >= 800 && pageHeight >= 1100);
                int copiesPerPage = isA4 ? 2 : 1, copiesPrinted = 0;

                Image? logo = null;
                string logoPath = Path.Combine(Application.StartupPath, "Images", "Logo.png");
                if (File.Exists(logoPath))
                    logo = Image.FromFile(logoPath);

                while (copiesPrinted < copiesPerPage)
                {
                    if (logo != null)
                    {
                        int maxWidth = 200, maxHeight = 100;
                        float ratio = Math.Min((float)maxWidth / logo.Width, (float)maxHeight / logo.Height);
                        int logoWidth = (int)(logo.Width * ratio), logoHeight = (int)(logo.Height * ratio);
                        g.DrawImage(logo, new Rectangle((pageWidth - logoWidth) / 2, y, logoWidth, logoHeight));
                    }
                    y += 80;
                    g.DrawLine(Pens.Black, xMargin, y, pageWidth - xMargin, y);
                    y += 20;

                    g.DrawString($"Order Date: {_orderDate:dd-MMM-yyyy}", normalFont, brush, xMargin, y);
                    y += 25;
                    g.DrawString($"Customer Name: {_customerName}", boldFont, brush, xMargin, y);
                    y += 20;
                    g.DrawString($"Address: {_address}", normalFont, brush, xMargin, y);
                    y += 30;
                    g.DrawLine(Pens.Black, xMargin, y, pageWidth - xMargin, y);
                    y += 20;
                    g.DrawString($"Driver Name: {_driverName}", boldFont, brush, xMargin, y);
                    y += 20;
                    g.DrawString($"Driver Phone: {_driverPhone}", normalFont, brush, xMargin, y);
                    y += 20;
                    g.DrawString($"Vehicle Details: {_vehicleDetails}", normalFont, brush, xMargin, y);
                    y += 30;
                    g.DrawLine(Pens.Black, xMargin, y, pageWidth - xMargin, y);
                    y += 20;
                    int col1 = xMargin, col2 = pageWidth / 3, col3 = 2 * pageWidth / 3, col4 = pageWidth - 100;
                    g.DrawString("Product", boldFont, brush, col1, y);
                    g.DrawString("Total SqFeet", boldFont, brush, col2, y);
                    g.DrawString("Unit Price", boldFont, brush, col3 - 10, y);
                    g.DrawString("Total", boldFont, brush, col4 - 10, y);
                    y += 20;

                    decimal totalPrice = _totalSqFeet * _unitPrice;
                    g.DrawString(_productName, normalFont, brush, col1, y);
                    g.DrawString(_totalSqFeet.ToString(), normalFont, brush, col2, y);
                    g.DrawString($"RS: {_unitPrice:N2}", normalFont, brush, col3 - 10, y);
                    g.DrawString($"RS: {totalPrice:N2}", normalFont, brush, col4 - 10, y);
                    y += 30;

                    g.DrawLine(Pens.Black, xMargin, y, pageWidth - xMargin, y);
                    y += 20;
                    g.DrawString("TOTAL AMOUNT:", boldFont, brush, col3 - 10, y);
                    g.DrawString($"RS: {totalPrice:N2}", boldFont, brush, col4 - 10, y);
                    y += 30;

                    g.DrawLine(Pens.Black, xMargin, y, pageWidth - xMargin, y);
                    y += 20;
                    g.DrawString("Shop Contact: 03333974999 03073918061 | Email: arifbehan786@gmail.com", normalFont, brush, xMargin, y);
                    y += 20;
                    g.DrawString("Larkana, Shikarpur Road Main, Bypass Garhi Yaseen", normalFont, brush, xMargin, y);
                    y += 30;

                    g.DrawLine(Pens.Black, xMargin, y, pageWidth - xMargin, y);
                    y += 40;
                    copiesPrinted++;

                    if (copiesPrinted < copiesPerPage) y += 20;
                }

                if (!isA4 && copiesPrinted < 2)
                    e.HasMorePages = true;

                logo?.Dispose();
            }
        }
    }

}
