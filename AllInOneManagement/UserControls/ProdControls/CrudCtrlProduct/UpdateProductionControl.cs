using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem.UserControls.ProductionControls.CrudControlsProduction
{
    public partial class UpdateProductionControl : UserControl
    {
        int id;
        string? oldproductName;
        int oldquantity;
        decimal oldlabourCost;
        string? oldrawMaterialUsed;
        string? olddescription;
        DateTime olddateProduced;

        public UpdateProductionControl(int Id, string? productName, int quantity, decimal labourCost,
                                   string? rawMaterialUsed, string? description, DateTime dateProduced)
        {
            InitializeComponent();
            id = Id;
            oldproductName = productName;
            oldquantity = quantity;
            oldlabourCost = labourCost;
            oldrawMaterialUsed = rawMaterialUsed;
            olddescription = description;
            olddateProduced = dateProduced;

            txtName.Text = oldproductName;
            txtQuantity.Text = oldquantity.ToString();
            TxtLabourCost.Text = oldlabourCost.ToString();
            txtRawUsed.Text = oldrawMaterialUsed;
            txtdescription.Text = olddescription;
            DatePicker.Value = olddateProduced;
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

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!ValidateInputs(out string newproductName, out int newquantity, out decimal newlabourCost,
                                out string newrawMaterialUsed, out string newdescription, out DateTime newdateProduced))
            {
                return; // Stop execution if validation fails
            }
            // Call function to Update production and update stock
            await UpdateProductionAndStockAsync(id, newproductName, newquantity, newlabourCost,
                                                  newrawMaterialUsed, newdateProduced, newdescription,
                                                  oldproductName, oldquantity, oldlabourCost, olddescription);




        }

        private bool ValidateInputs(out string newproductName, out int newquantity, out decimal newlabourCost,
                            out string newrawMaterialUsed, out string newdescription, out DateTime newdateProduced)
        {
            // Get trimmed values from input fields
            newproductName = txtName.Text.Trim();
            newrawMaterialUsed = txtRawUsed.Text.Trim();
            newdescription = txtdescription.Text.Trim();
            newdateProduced = DatePicker.Value;

            // Default values if parsing fails
            newquantity = 0;
            newlabourCost = 0;

            // Required field checks
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtQuantity.Text) ||
                string.IsNullOrEmpty(TxtLabourCost.Text) || string.IsNullOrEmpty(txtRawUsed.Text) || string.IsNullOrEmpty(txtdescription.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Numeric Validations
            if (!int.TryParse(txtQuantity.Text, out newquantity) || newquantity <= 0)
            {
                MessageBox.Show("Quantity must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(TxtLabourCost.Text, out newlabourCost) || newlabourCost < 0)
            {
                MessageBox.Show("Labour Cost must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Validation Passed
        }
        private async Task UpdateProductionAndStockAsync(int productionID, string? newProductName, int newQuantity, decimal newLabourCost,
                                                          string? newRawMaterialUsed, DateTime newDateProduced, string? newDescription,
                                                          string? oldProductName, int oldQuantity, decimal oldLabourCost, string? oldDescription)
        {
            try
            {
                btnUpdate.Enabled = false; // Disable button to prevent multiple clicks
                                           // Open connection asynchronously
                using (SqlConnection conn = new SqlConnection(DatabaseOperation.GetConnectionString()))
                {
                    await conn.OpenAsync(); // Open connection asynchronously

                    using (SqlCommand cmd = new SqlCommand("UpdateProductionAndStock", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Pass parameters to stored procedure
                        cmd.Parameters.AddWithValue("@ProductionID", productionID);
                        cmd.Parameters.AddWithValue("@NewProductName", newProductName);
                        cmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
                        cmd.Parameters.AddWithValue("@NewLabourCost", newLabourCost);
                        cmd.Parameters.AddWithValue("@NewRawMaterialUsed", newRawMaterialUsed);
                        cmd.Parameters.AddWithValue("@NewDateProduced", newDateProduced);
                        cmd.Parameters.AddWithValue("@NewDescription", newDescription);
                        cmd.Parameters.AddWithValue("@OldProductName", oldProductName);
                        cmd.Parameters.AddWithValue("@OldQuantity", oldQuantity);
                        cmd.Parameters.AddWithValue("@OldLabourCost", oldLabourCost);
                        cmd.Parameters.AddWithValue("@OldDescription", oldDescription);

                        // Output parameter for affected rows
                        SqlParameter outputAffectedRows = new SqlParameter("@AffectedRows", SqlDbType.Int)
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
                            MessageBox.Show("Production and stock updated successfully.");
                            // Clear fields after successful operation
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Please check your input or the data.");
                            return;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL Server specific exceptions (including RAISERROR from stored procedure)
                MessageBox.Show($"Database Error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle exceptions and show appropriate message
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnUpdate.Enabled = true; // Enable button after operation completes
            }
        }



        private void ClearFields()
        {
            txtName.Clear();
            txtQuantity.Clear();
            TxtLabourCost.Clear();
            txtRawUsed.Clear();
            txtdescription.Clear();
            DatePicker.Value = DateTime.Now;
        }
    }
}
