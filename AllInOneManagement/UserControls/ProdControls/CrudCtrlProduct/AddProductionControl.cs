using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem.UserControls.ProductionControls.CrudControlsProduction
{
    public partial class AddProductionControl : UserControl
    {
        public AddProductionControl()
        {
            InitializeComponent();
            DatePicker.Value = DateTime.Now;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true; // Cancel the input if it's not a digit, decimal point, or Backspace
            }
            if (e.KeyChar == '.' && txtQuantity.Text.Contains('.'))
            {
                e.Handled = true; // Cancel the input if there is already a decimal point
            }
        }

        private void TxtLabourCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true; // Cancel the input if it's not a digit, decimal point, or Backspace
            }
            if (e.KeyChar == '.' && TxtLabourCost.Text.Contains('.'))
            {
                e.Handled = true; // Cancel the input if there is already a decimal point
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!ValidateInputs(out string productName, out decimal quantity, out decimal Cementquantity, out decimal labourCost,
                                out string rawMaterialUsed, out string description, out DateTime dateProduced))
            {
                return; // Stop execution if validation fails
            }

            // Call function to insert production and update stock
            await AddProductionAndUpdateStock(productName, quantity, Cementquantity, labourCost, rawMaterialUsed, description, dateProduced);

            // Clear fields after successful operation
            ClearFields();
        }

        private bool ValidateInputs(out string productName, out decimal quantity, out decimal Cementquantity, out decimal labourCost,
                            out string rawMaterialUsed, out string description, out DateTime dateProduced)
        {
            // Get trimmed values from input fields
            productName = txtName.Text.Trim();
            rawMaterialUsed = txtRawUsed.Text.Trim();
            description = txtdescription.Text.Trim();
            dateProduced = DatePicker.Value;

            // Default values if parsing fails
            quantity = 0;
            labourCost = 0;
            Cementquantity = 0;

            // Required field checks
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(txtQuantity.Text) ||
                string.IsNullOrEmpty(TxtLabourCost.Text) || string.IsNullOrEmpty(rawMaterialUsed) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Numeric Validations
            if (!decimal.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Numeric Validations
            if (!decimal.TryParse(txtcement.Text, out Cementquantity) || Cementquantity <= 0)
            {
                MessageBox.Show("Cement Quantity must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(TxtLabourCost.Text, out labourCost) || labourCost < 0)
            {
                MessageBox.Show("Labour Cost must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Validation Passed
        }
        private async Task AddProductionAndUpdateStock(string productName, decimal quantity, decimal Cementquantity, decimal labourCost,
                                               string rawMaterialUsed, string description, DateTime dateProduced)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseOperation.GetConnectionString()))
                {
                    await conn.OpenAsync(); // Open connection asynchronously

                    using (SqlCommand cmd = new SqlCommand("AddProductionAndStock", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Pass parameters to stored procedure
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@LabourCost", labourCost);
                        cmd.Parameters.AddWithValue("@RawMaterialUsed", rawMaterialUsed);
                        cmd.Parameters.AddWithValue("@DateProduced", dateProduced);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@CementQuantity", Cementquantity);

                        // Read the result from the stored procedure
                        object result = await cmd.ExecuteScalarAsync();

                        if (result != null && result.ToString().Contains("Error"))
                        {
                            MessageBox.Show(result.ToString(), "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Stop further execution
                        }

                        MessageBox.Show("Production added and stock and cash flow updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ClearFields()
        {
            txtName.Clear();
            txtQuantity.Clear();
            TxtLabourCost.Clear();
            txtcement.Clear();
            txtRawUsed.Clear();
            txtdescription.Clear();
            DatePicker.Value = DateTime.Now;
        }

        private void txtcement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true; // Cancel the input if it's not a digit, decimal point, or Backspace
            }
            if (e.KeyChar == '.' && txtcement.Text.Contains('.'))
            {
                e.Handled = true; // Cancel the input if there is already a decimal point
            }
        }
    }
}
