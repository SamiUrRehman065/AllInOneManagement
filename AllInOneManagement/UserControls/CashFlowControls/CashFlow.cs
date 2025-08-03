using FactoryManagementSystem.UserControls.CashFlowControls.CrudControlsCashFlow;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem.UserControls
{

    public partial class CashFlow : UserControl
    {
        private DataTable originalData = new();
        public CashFlow()
        {
            InitializeComponent();
            LoadCashFlowAsync(); // Populate grid when UserControl loads

        }
        private async void LoadCashFlowAsync()
        {
            try
            {
                originalData = await DatabaseOperation.GetTableDataAsync("CashFlow");
                cashflowgridview.DataSource = originalData;
                cashflowgridview.ClearSelection();
                cashflowgridview.Columns["Amount"].DefaultCellStyle.Format = "N0";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading CashFlow: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                LoadCashFlowAsync();// Reset to original data
                return;
            }

            var filteredRows = originalData.AsEnumerable().Where(row => row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchText)));

            if (filteredRows.Any())
            {
                cashflowgridview.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                if (isBackspacePressed)
                {
                    cashflowgridview.DataSource = originalData.Clone(); // Show empty table but no message
                }
                else
                {
                    MessageBox.Show("No matching data found. Please check your input.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cashflowgridview.DataSource = originalData.Clone();
                }
                isBackspacePressed = false; // Reset flag after handling

            }
        }

        private void btnaddCashFlow_Click(object sender, EventArgs e)
        {
            Popup popup = new(new AddCashFlowControl());

            popup.ShowDialog();
            LoadCashFlowAsync();
        }

        private void btnupdatecashflow_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (cashflowgridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Get the selected row data
                DataGridViewRow selectedRow = cashflowgridview.SelectedRows[0];
                // Extract values from the selected row
                int cashFlowID = Convert.ToInt32(selectedRow.Cells["CashFlowID"].Value);
                DateTime cashFlowDate = Convert.ToDateTime(selectedRow.Cells["CashFlowDate"].Value);
                decimal amount = Convert.ToDecimal(selectedRow.Cells["Amount"].Value);
                string? type = selectedRow.Cells["Type"].Value.ToString();
                string? reason = selectedRow.Cells["Reason"].Value.ToString();
                string? description = selectedRow.Cells["Description"].Value.ToString();
                Popup popup = new(new UpdateCashFlowControl(cashFlowID, cashFlowDate, amount, type, reason, description));
                popup.ShowDialog();
                LoadCashFlowAsync(); // Populate grid when cash flow is updated
            }
        }

        private async void btndeleteCashFlow_Click(object sender, EventArgs e)
        {

            try
            {
                // **Step 1: Check if a row is selected**
                if (cashflowgridview.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // **Step 2: Extract data from selected row**
                DataGridViewRow selectedRow = cashflowgridview.SelectedRows[0];
                int CashFlowID = Convert.ToInt32(selectedRow.Cells["CashFlowID"].Value);
                string? Reason = selectedRow.Cells["Reason"].Value.ToString();
                string? description = selectedRow.Cells["Description"].Value.ToString();


                // **Step 3: Show confirmation message**
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete:\nCashFlow: {Reason}\nDescription: {description}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                    return; // **User cancelled deletion**

                // **Step 4: Call the async delete function**
                await DeleteCashFlowAsync(CashFlowID);

                // **Step 5: Refresh DataGridView after successful deletion**
                LoadCashFlowAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static async Task DeleteCashFlowAsync(int CashFlowID)
        {
            try
            {
                using (SqlConnection connection = new(DatabaseOperation.GetConnectionString()))
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new("DeleteCashFlow", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // **Pass parameters to stored procedure**
                        cmd.Parameters.AddWithValue("@CashFlowID", CashFlowID);



                        // **Execute delete operation asynchronously**
                        int result = await cmd.ExecuteNonQueryAsync();

                        // **Check if deletion was successful**

                        if (result > 0)
                        {
                            MessageBox.Show("Cash Flow deleted successfully.");
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
