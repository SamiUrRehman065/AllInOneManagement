using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem.UserControls.CashFlowControls.CrudControlsCashFlow
{
    public partial class AddCashFlowControl : UserControl
    {
        public AddCashFlowControl()
        {
            InitializeComponent();
            DatePicker.Value = DateTime.Now;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            // Step 1: Validate the inputs
            if (!ValidateInputs())
            {
                return;
            }
            // Step 2: Create a CashFlow object to pass data
            // Extract values directly from controls
            DateTime cashFlowDate = DatePicker.Value;
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            string? type = cmbtype.SelectedItem?.ToString();
            string reason = txtReason.Text;
            string description = txtdescription.Text;
            try
            {
                // Disable the button during async operation to prevent multiple clicks
                btnAdd.Enabled = false;
                // Call the stored procedure directly
                bool isSuccess = await AddCashFlowAsync(cashFlowDate, amount, type, reason, description);

                if (isSuccess)
                {
                    MessageBox.Show("Cash flow added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add cash flow.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Re-enable the button after the operation completes
                btnAdd.Enabled = true;
            }
        }

        private bool ValidateInputs()
        {
            // Step 1: Validate Amount
            if (string.IsNullOrWhiteSpace(txtAmount.Text) || !decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Step 2: Validate Type (Inflow or Outflow)
            if (cmbtype.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the type (Inflow or Outflow).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Step 3: Validate Reason
            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Reason cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Step 4: Validate Description
            if (string.IsNullOrWhiteSpace(txtdescription.Text))
            {
                MessageBox.Show("Description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Step 5: Validate Date
            if (DatePicker.Value == null)
            {
                MessageBox.Show("Please select a valid date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // All validations passed
        }

        private async Task<bool> AddCashFlowAsync(DateTime cashFlowDate, decimal amount, string? type, string reason, string description)
        {
            try
            {
                using (SqlConnection connection = new(DatabaseOperation.GetConnectionString())) // Use your connection string
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new("AddCashFlow", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@CashFlowDate", cashFlowDate);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@Type", type);
                        command.Parameters.AddWithValue("@Reason", reason);
                        command.Parameters.AddWithValue("@Description", description);

                        // Execute the stored procedure
                        int rowsAffected = await command.ExecuteNonQueryAsync();
                        return rowsAffected > 0; // If any row was affected, return true
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // Clear form fields after success
        private void ClearForm()
        {
            txtAmount.Clear();
            txtReason.Clear();
            txtdescription.Clear();
            cmbtype.SelectedIndex = -1;
            DatePicker.Value = DateTime.Now;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true; // Cancel the input if it's not a digit, decimal point, or Backspace
            }
            if (e.KeyChar == '.' && txtAmount.Text.Contains('.'))
            {
                e.Handled = true; // Cancel the input if there is already a decimal point
            }
        }
    }
}
