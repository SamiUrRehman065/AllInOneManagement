using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem.UserControls.RawMaterialsControls.CrudControlsRawMaterial
{
    public partial class AddRawMaterialControl : UserControl
    {
        readonly string connectionString = DatabaseOperation.GetConnectionString();
        private readonly string Type;
        private DataTable ProviderData = new();
        private int? ProviderId = null;
        public AddRawMaterialControl(string type)
        {
            InitializeComponent();
            Type = type;
            RawMDatePicker.Value = DateTime.Now;

            if (Type == "Cash")
            {
                ProviderGridview.Visible = false;
                NewLeadgweCheckBox.Visible = false;
                lblProviderHeader.Visible = false;
            }
            else
            {
                LoadProviderAsync().ConfigureAwait(false);
                txtPName.Enabled = false;

                TxtPhoneNo.Enabled = false;
            }
        }

        private async Task LoadProviderAsync()
        {
            try
            {
                ProviderData = await DatabaseOperation.GetTableDataAsync("Providers");


                ProviderGridview.DataSource = ProviderData;
                ProviderGridview.ClearSelection();
                // Set custom column headers
                ProviderGridview.Columns["ProviderID"].HeaderText = "ID";
                ProviderGridview.Columns["ProviderName"].HeaderText = "Name";
                ProviderGridview.Columns["CNIC"].Visible = false;
                ProviderGridview.Columns["Contact"].HeaderText = "Phone";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Providers Data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRawMQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true; // Cancel the input if it's not a digit, decimal point, or Backspace
            }
            if (e.KeyChar == '.' && txtRawMQuantity.Text.Contains('.'))
            {
                e.Handled = true; // Cancel the input if there is already a decimal point
            }
        }

        private void txtRawMprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true; // Cancel the input if it's not a digit, decimal point, or Backspace
            }
            if (e.KeyChar == '.' && txtRawMprice.Text.Contains('.'))
            {
                e.Handled = true; // Cancel the input if there is already a decimal point
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateRawMaterialInputs(out decimal quantity, out decimal pricePerUnit, out DateTime selectedDate))
            {
                if (Type == "Cash")
                {
                    await AddCashRawMaterialAsync(txtRawMName.Text.Trim(), quantity, pricePerUnit, txtRawMdescription.Text.Trim(), txtPName.Text.Trim(), TxtPhoneNo.Text.Trim(), selectedDate);
                }
                else
                {
                    await InsertCreditRawMaterialAsync(ProviderId, txtPName.Text.Trim(), TxtPhoneNo.Text.Trim(), txtRawMName.Text.Trim(), quantity, pricePerUnit, selectedDate, txtRawMdescription.Text.Trim());
                }
            }
        }
        private async Task AddCashRawMaterialAsync(
            string materialName, decimal quantity, decimal pricePerUnit, string description,
            string providerName, string providerContact, DateTime dateAdded)
        {
            try
            {
                // Calculate Total Price
                decimal totalPrice = quantity * pricePerUnit;



                using (SqlConnection conn = new(connectionString))
                {
                    using (SqlCommand cmd = new("AddRawMaterial_CashPurchase", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure; // Set Command Type as Stored Procedure

                        // Add Parameters
                        cmd.Parameters.AddWithValue("@MaterialName", materialName);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@PricePerUnit", pricePerUnit);
                        cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        cmd.Parameters.AddWithValue("@DateAdded", dateAdded);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@ProviderName", providerName);
                        cmd.Parameters.AddWithValue("@ProviderContact", providerContact);
                        cmd.Parameters.AddWithValue("@ProviderCNIC", "");


                        await conn.OpenAsync(); // Open Connection
                        int result = await cmd.ExecuteNonQueryAsync(); // Execute Stored Procedure
                        if (result > 0)
                        {
                            MessageBox.Show("Raw Material added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Raw Material.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task InsertCreditRawMaterialAsync(
        int? providerID, string providerName, string providerContact,
        string materialName, decimal quantity, decimal pricePerUnit, DateTime dateAdded, string description)
        {
            try
            {
                using (SqlConnection conn = new(connectionString))
                {
                    await conn.OpenAsync();
                    using (SqlCommand cmd = new("InsertCreditRawMaterial", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Adding parameters
                        cmd.Parameters.AddWithValue("@ProviderID", (object)providerID ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ProviderName", providerName);
                        cmd.Parameters.AddWithValue("@ProviderCNIC", "");
                        cmd.Parameters.AddWithValue("@ProviderContact", providerContact);
                        cmd.Parameters.AddWithValue("@MaterialName", materialName);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@PricePerUnit", pricePerUnit);
                        cmd.Parameters.AddWithValue("@DateAdded", dateAdded);
                        cmd.Parameters.AddWithValue("@Description", description);

                        // Execute and return the number of affected rows

                        int result = await cmd.ExecuteNonQueryAsync(); // Execute Stored Procedure
                        if (result > 0)
                        {
                            MessageBox.Show("Raw Material added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Raw Material.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void ClearFields()
        {
            txtRawMName.Clear();
            txtRawMQuantity.Clear();
            txtRawMprice.Clear();
            txtRawMdescription.Clear();
            RawMDatePicker.Value = DateTime.Now;
            txtPName.Clear();

            TxtPhoneNo.Clear();


        }

        private void NewLeadgweCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NewLeadgweCheckBox.Checked)
            {
                txtPName.Enabled = true;

                TxtPhoneNo.Enabled = true;
                ProviderGridview.Enabled = false;
                ProviderGridview.Visible = false;
                txtPName.Text = string.Empty;

                TxtPhoneNo.Text = string.Empty;
                ProviderId = null;
            }
            else
            {
                txtPName.Enabled = false;

                TxtPhoneNo.Enabled = false;
                ProviderGridview.Enabled = true;
                ProviderGridview.Visible = true;
            }
        }

        private void ProviderGridview_SelectionChanged(object sender, EventArgs e)
        {
            if (ProviderGridview.CurrentRow != null)
            {
                txtPName.Text = ProviderGridview.CurrentRow.Cells["ProviderName"].Value.ToString();

                TxtPhoneNo.Text = ProviderGridview.CurrentRow.Cells["Contact"].Value.ToString();
                ProviderId = Convert.ToInt32(ProviderGridview.CurrentRow.Cells["ProviderID"].Value);

            }
        }


        private bool ValidateRawMaterialInputs(out decimal quantity, out decimal pricePerUnit, out DateTime selectedDate)
        {
            quantity = 0;
            pricePerUnit = 0;
            selectedDate = DateTime.MinValue;

            // Check for empty fields
            if (string.IsNullOrWhiteSpace(txtRawMName.Text) ||
                string.IsNullOrWhiteSpace(txtRawMQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtRawMprice.Text) ||
                string.IsNullOrWhiteSpace(txtRawMdescription.Text) ||
                string.IsNullOrWhiteSpace(txtPName.Text) ||
                string.IsNullOrWhiteSpace(TxtPhoneNo.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Quantity
            if (!decimal.TryParse(txtRawMQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Price Per Unit
            if (!decimal.TryParse(txtRawMprice.Text, out pricePerUnit) || pricePerUnit <= 0)
            {
                MessageBox.Show("Price per unit must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Date Selection
            selectedDate = RawMDatePicker.Value;
            if (selectedDate == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Please select a valid date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // All validations passed
        }

        private void CementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CementCheckBox.Checked)
            {
                txtRawMName.Text = "Cement";
                txtRawMName.ReadOnly = true;
            }
            else
            {
                txtRawMName.Text = string.Empty;
                txtRawMName.ReadOnly = false;
            }
        }
    }
}
