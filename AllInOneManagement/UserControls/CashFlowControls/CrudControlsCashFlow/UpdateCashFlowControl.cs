using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem.UserControls.CashFlowControls.CrudControlsCashFlow
{
    public partial class UpdateCashFlowControl : UserControl
    {
        // Declare fields to hold the passed data
        private int _cashFlowID;
        private DateTime _cashFlowDate;
        private decimal _amount;
        private string? _type;
        private string? _reason;
        private string? _description;
        public UpdateCashFlowControl(int cashFlowID, DateTime cashFlowDate, decimal amount, string? type, string? reason, string? description)
        {
            InitializeComponent();
            // Assign the passed data to the fields
            _cashFlowID = cashFlowID;
            _cashFlowDate = cashFlowDate;
            _amount = amount;
            _type = type;
            _reason = reason;
            _description = description;
            // Set the values of the controls to the passed data
            DatePicker.Value = _cashFlowDate;
            txtAmount.Text = _amount.ToString();
            cmbtype.SelectedItem = _type;
            txtReason.Text = _reason;
            txtdescription.Text = _description;
        }
        private async Task UpdateCashFlowAsync(int cashFlowID, DateTime newCashFlowDate, decimal newAmount, string? newType, string newReason, string newDescription)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseOperation.GetConnectionString()))
                {
                    await conn.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand("UpdateCashFlow", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@CashFlowID", cashFlowID);
                        cmd.Parameters.AddWithValue("@CashFlowDate", newCashFlowDate);
                        cmd.Parameters.AddWithValue("@Amount", newAmount);
                        cmd.Parameters.AddWithValue("@Type", newType ?? (object)DBNull.Value);  // Handle null Type
                        cmd.Parameters.AddWithValue("@Reason", string.IsNullOrEmpty(newReason) ? (object)DBNull.Value : newReason);  // Handle empty Reason
                        cmd.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(newDescription) ? (object)DBNull.Value : newDescription);  // Handle empty Description


                        // Execute the stored procedure asynchronously
                        int result = await cmd.ExecuteNonQueryAsync();

                        // Retrieve the affected rows count from the output parameter


                        // Check if the update was successful
                        if (result > 0)
                        {
                            MessageBox.Show("Cash flow updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Please check your input or the data.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            // Step 1: Validate the inputs
            if (!ValidateInputs())
            {
                return;
            }
            // Capture the updated values entered in the form
            DateTime newCashFlowDate = DatePicker.Value;
            decimal newAmount = decimal.Parse(txtAmount.Text);
            string? newType = cmbtype.SelectedItem.ToString();
            string newReason = txtReason.Text;
            string newDescription = txtdescription.Text;

            // Call the method to update the database
            // Method to call the stored procedure for updating the CashFlow
            await UpdateCashFlowAsync(_cashFlowID, newCashFlowDate, newAmount, newType, newReason, newDescription);
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

    }
}
