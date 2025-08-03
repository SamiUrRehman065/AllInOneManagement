using FactoryManagementSystem.UserControls.RawMaterialsControls.CrudControlsRawMaterial;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem.UserControls
{
    public partial class Rawmaterials : UserControl
    {
        private DataTable originalData = new();
        public Rawmaterials()
        {
            InitializeComponent();
            LoadRawMaterialsAsync().ConfigureAwait(false); // Populate grid when UserControl loads

        }

        private async Task LoadRawMaterialsAsync()
        {
            try
            {
                originalData = await DatabaseOperation.GetTableDataAsync("RawMaterials");
                rawmaterialgridview.DataSource = originalData;
                rawmaterialgridview.ClearSelection();
                rawmaterialgridview.Columns["RawMaterialID"].HeaderText = "ID";
                rawmaterialgridview.Columns["RawMaterialID"].Visible = false;
                rawmaterialgridview.Columns["MaterialName"].HeaderText = "Name";
                rawmaterialgridview.Columns["Quantity"].HeaderText = "Quantity";
                rawmaterialgridview.Columns["PricePerUnit"].HeaderText = "Unit Price";
                rawmaterialgridview.Columns["PricePerUnit"].DefaultCellStyle.Format = "N0";
                rawmaterialgridview.Columns["TotalPrice"].HeaderText = "Total Price";
                rawmaterialgridview.Columns["TotalPrice"].DefaultCellStyle.Format = "N2";
                rawmaterialgridview.Columns["DateAdded"].HeaderText = "Date";
                rawmaterialgridview.Columns["Description"].HeaderText = "Description";
                rawmaterialgridview.Columns["ProviderName"].HeaderText = "Provider Name";
                rawmaterialgridview.Columns["ProviderContact"].HeaderText = "Contact";
                rawmaterialgridview.Columns["ProviderCNIC"].Visible = false;
                rawmaterialgridview.Columns["LedgerID"].HeaderText = "Ledger ID";
                rawmaterialgridview.Columns["LedgerID"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading raw materials: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void btnaddrawmaterial_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
            $"Is Raw Material A cash Type? \nSelect Yes For Cash.\nAnd No For Credit.",
            "Order Type",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Popup popup = new(new AddRawMaterialControl("Cash"));
                popup.ShowDialog();
                await LoadRawMaterialsAsync();
            }
            else if (result == DialogResult.No)
            {
                Popup popup = new(new AddRawMaterialControl("Credit"));
                popup.ShowDialog();
                await LoadRawMaterialsAsync();
            }
        }

        private async void btndeleterawmaterial_Click(object sender, EventArgs e)
        {
            try
            {
                // **Step 1: Check if a row is selected**
                if (rawmaterialgridview.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // **Step 2: Extract data from selected row**
                DataGridViewRow selectedRow = rawmaterialgridview.SelectedRows[0];
                int materialID = Convert.ToInt32(selectedRow.Cells["RawMaterialID"].Value);
                string? materialName = selectedRow.Cells["MaterialName"].Value.ToString();
                string? description = selectedRow.Cells["Description"].Value.ToString();
                decimal totalAmount = Convert.ToDecimal(selectedRow.Cells["TotalPrice"].Value);

                // **Step 3: Show confirmation message**
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete:\nMaterial: {materialName}\nReason: {description}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                    return; // **User cancelled deletion**

                // **Step 4: Call the async delete function**
                await DeleteRawMaterialAsync(materialID, materialName, description, totalAmount);

                // **Step 5: Refresh DataGridView after successful deletion**
                await LoadRawMaterialsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private static async Task DeleteRawMaterialAsync(int materialID, string? materialName, string? description, decimal totalAmount)
        {
            try
            {
                using (SqlConnection connection = new(DatabaseOperation.GetConnectionString()))
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new("DeleteRawMaterialByID", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // **Pass parameters to stored procedure**
                        cmd.Parameters.AddWithValue("@MaterialID", materialID);
                        cmd.Parameters.AddWithValue("@MaterialName", materialName);
                        cmd.Parameters.AddWithValue("@OldDescription", description);
                        cmd.Parameters.AddWithValue("@OldTotalAmount", totalAmount);

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
                            MessageBox.Show("Raw material and associated cash flow deleted successfully.");
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


        private async void btnupdaterawmaterials_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (rawmaterialgridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Row  to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                // Get the selected row data
                DataGridViewRow selectedRow = rawmaterialgridview.SelectedRows[0];
                // Extract values from the selected row
                int materialID = Convert.ToInt32(selectedRow.Cells["RawMaterialID"].Value);
                string? materialName = selectedRow.Cells["MaterialName"].Value.ToString();
                int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                decimal pricePerUnit = Convert.ToDecimal(selectedRow.Cells["PricePerUnit"].Value);
                decimal totalPrice = Convert.ToDecimal(selectedRow.Cells["TotalPrice"].Value);
                DateTime dateAdded = Convert.ToDateTime(selectedRow.Cells["DateAdded"].Value);
                string? description = selectedRow.Cells["Description"].Value.ToString();
                Popup popup = new(new UpdateRawMaterialControl(materialID, materialName, quantity, pricePerUnit, totalPrice, dateAdded, description));
                popup.ShowDialog();
                await LoadRawMaterialsAsync(); // Populate grid when raw material is updated
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
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string searchText = txtSearch.Text.ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                await LoadRawMaterialsAsync();// Reset to original data
                return;
            }

            var filteredRows = originalData.AsEnumerable().Where(row => row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchText)));

            if (filteredRows.Any())
            {
                rawmaterialgridview.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                if (isBackspacePressed)
                {
                    rawmaterialgridview.DataSource = originalData.Clone(); // Show empty table but no message
                }
                else
                {
                    MessageBox.Show("No matching data found. Please check your input.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rawmaterialgridview.DataSource = originalData.Clone();
                }
                isBackspacePressed = false; // Reset flag after handling

            }
        }


    }
}
