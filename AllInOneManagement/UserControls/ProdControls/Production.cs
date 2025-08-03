using FactoryManagementSystem.UserControls.ProductionControls.CrudControlsProduction;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem.UserControls
{
    public partial class Production : UserControl
    {
        private DataTable originalData = new();
        public Production()
        {
            InitializeComponent();
            LoadProductionAsync(); // Populate grid when UserControl loads
        }
        private async void LoadProductionAsync()
        {
            try
            {
                originalData = await DatabaseOperation.GetTableDataAsync("Production");
                productiongridview.DataSource = originalData;
                productiongridview.ClearSelection();
                productiongridview.Columns["LabourCost"].DefaultCellStyle.Format = "N0";
                productiongridview.Columns["LabourCost"].HeaderText = "Cost";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Productions Record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isBackspacePressed = false; // Global flag to track Backspace press
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                isBackspacePressed = true; // Set flag when Backspace is pressed
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string searchText = txtSearch.Text.ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                LoadProductionAsync();// Reset to original data
                return;
            }

            var filteredRows = originalData.AsEnumerable().Where(row => row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchText)));

            if (filteredRows.Any())
            {
                productiongridview.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                if (isBackspacePressed)
                {
                    productiongridview.DataSource = originalData.Clone(); // Show empty table but no message
                }
                else
                {
                    MessageBox.Show("No matching data found. Please check your input.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productiongridview.DataSource = originalData.Clone();
                }
                isBackspacePressed = false; // Reset flag after handling

            }
        }

        private void btnaddproduction_Click(object sender, EventArgs e)
        {
            Popup popup = new(new AddProductionControl());
            popup.ShowDialog();
            LoadProductionAsync(); // Populate grid when production is added
        }

        private void btnupdateproduction_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (productiongridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extract values from the selected row
            var selectedRow = productiongridview.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["ProductionID"].Value); // Assuming 'ProductionID' is the column for the ID
            string? productName = selectedRow.Cells["ProductName"].Value.ToString();
            int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
            decimal labourCost = Convert.ToDecimal(selectedRow.Cells["LabourCost"].Value);
            string? rawMaterialUsed = selectedRow.Cells["RawMaterialUsed"].Value.ToString();
            string? description = selectedRow.Cells["Description"].Value.ToString();
            DateTime dateProduced = Convert.ToDateTime(selectedRow.Cells["DateProduced"].Value);

            // Save old values in local variables (you can use these later for updating the database)
            // For now, we'll just pass them to the UpdateProductionControl UserControl
            UpdateProductionControl updateProductionControl = new(id, productName, quantity, labourCost, rawMaterialUsed, description, dateProduced);
            Popup popup = new(updateProductionControl);
            popup.ShowDialog();
            LoadProductionAsync(); // Refresh grid after update
        }

        private async void btndeleteproduction_Click(object sender, EventArgs e)
        {
            try
            {
                // **Step 1: Check if a row is selected**
                if (productiongridview.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // **Step 2: Extract data from selected row**
                DataGridViewRow selectedRow = productiongridview.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ProductionID"].Value); // Assuming 'ProductionID' is the column for the ID
                string? productName = selectedRow.Cells["ProductName"].Value.ToString();
                decimal labourCost = Convert.ToDecimal(selectedRow.Cells["LabourCost"].Value);
                string? description = selectedRow.Cells["Description"].Value.ToString();

                // **Step 3: Show confirmation message**
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete:\nProduction: {productName}\nDescription: {description}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                    return; // **User cancelled deletion**

                // **Step 4: Call the async delete function**
                await DeleteRawMaterialAsync(id, productName, labourCost, description);

                // **Step 5: Refresh DataGridView after successful deletion**
                LoadProductionAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static async Task DeleteRawMaterialAsync(int id, string? productName, decimal totalAmount, string? description)
        {
            try
            {
                using (SqlConnection connection = new(DatabaseOperation.GetConnectionString()))
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new("DeleteProductionAndUpdateStock", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // **Pass parameters to stored procedure**
                        cmd.Parameters.AddWithValue("@ProductionID", id);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@Amount", totalAmount);
                        cmd.Parameters.AddWithValue("@Description", description);

                        // **Output parameter to track affected rows**
                        SqlParameter outputAffectedRows = new("@AffectedRows", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputAffectedRows);

                        // **Execute delete operation asynchronously**
                        await cmd.ExecuteNonQueryAsync();

                        // **Check if deletion was successful**
                        int affectedRows = (int)outputAffectedRows.Value;
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Production and associated cash flow deleted successfully. Stock Updated Successfuly.");
                        }
                        else
                        {
                            MessageBox.Show("No records deleted. Please check your input.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
