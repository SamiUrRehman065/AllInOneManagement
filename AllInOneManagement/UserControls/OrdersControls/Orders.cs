using FactoryManagementSystem.UserControls.OrdersControls.CrudControlsOrder;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem.UserControls
{
    public partial class Orders : UserControl
    {
        private DataTable originalData = new();
        public Orders()
        {
            InitializeComponent();
            LoadOrdersAsync();


        }
        private async void LoadOrdersAsync()
        {
            try
            {
                originalData = await DatabaseOperation.GetTableDataAsync("Orders");
                ordersgridview.DataSource = originalData;
                ordersgridview.ClearSelection();
                ordersgridview.Columns["OrderID"].Visible = false;
                ordersgridview.Columns["OrderDate"].HeaderText = "Date";
                ordersgridview.Columns["Quantity"].HeaderText = "Quantity";
                ordersgridview.Columns["Quantity"].DefaultCellStyle.Format = "N0";
                ordersgridview.Columns["UnitPrice"].HeaderText = "Rate";
                ordersgridview.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";
                ordersgridview.Columns["TotalPrice"].HeaderText = "Total";
                ordersgridview.Columns["TotalPrice"].DefaultCellStyle.Format = "N0"; // 2 decimal places
                ordersgridview.Columns["Total SqFeet"].DefaultCellStyle.Format = "N0"; // 2 decimal places
                ordersgridview.Columns["Description"].HeaderText = "Description";
                ordersgridview.Columns["Address"].HeaderText = "Address";
                ordersgridview.Columns["CustomerName"].HeaderText = "Name";
                ordersgridview.Columns["CustomerCNIC"].Visible = false;
                ordersgridview.Columns["CustomerPhone"].HeaderText = "Phone";
                ordersgridview.Columns["PaidAmount"].HeaderText = "Paid Amount";
                ordersgridview.Columns["PaidAmount"].DefaultCellStyle.Format = "N0";
                ordersgridview.Columns["RemainingBalance"].HeaderText = "Remaining Balance";
                ordersgridview.Columns["RemainingBalance"].DefaultCellStyle.Format = "N0";
                ordersgridview.Columns["LedgerID"].Visible = false;
                //ordersgridview.Columns["UnitPrice"].DefaultCellStyle.Format = "'Rs '0";
                //ordersgridview.Columns["TotalPrice"].DefaultCellStyle.Format = "'Rs '0";



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Order Records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnaddOrders_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                  $"Is Order A cash Type? \nSelect Yes For Cash.\nAnd No For Credit.",
                  "Order Type",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Popup popup = new Popup(new AddOrderControl("Cash"));
                popup.ShowDialog();
                LoadOrdersAsync();
            }
            else if (result == DialogResult.No)
            {
                Popup popup = new Popup(new AddOrderControl("Credit"));
                popup.ShowDialog();
                LoadOrdersAsync();
            }
        }

        private async void btndeleteorders_Click(object sender, EventArgs e)
        {
            if (ordersgridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId = Convert.ToInt32(ordersgridview.SelectedRows[0].Cells["OrderID"].Value);
            string? description = ordersgridview.SelectedRows[0].Cells["Description"].Value.ToString();
            string? address = ordersgridview.SelectedRows[0].Cells["Address"].Value.ToString();
            string? customerName = ordersgridview.SelectedRows[0].Cells["CustomerName"].Value.ToString();


            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete Order ID : {orderId}?\nCustomer Name : {customerName}\nDescription : {description}\nAddress : {address}",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                await DeleteOrderAsync(orderId);
            }
            else
            {
                return;
            }

        }

        private async Task DeleteOrderAsync(int orderId)
        {
            try
            {
                using (SqlConnection conn = new(DatabaseOperation.GetConnectionString()))
                {
                    await conn.OpenAsync();
                    using (SqlCommand cmd = new("DeleteOrder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@OrderID", orderId);


                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Order ID {orderId} deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadOrdersAsync();
                        }
                        else
                        {
                            MessageBox.Show("Order deletion failed. No matching record found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string searchText = txtSearch.Text.ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                LoadOrdersAsync();// Reset to original data
                return;
            }

            var filteredRows = originalData.AsEnumerable().Where(row => row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchText)));

            if (filteredRows.Any())
            {
                ordersgridview.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                if (isBackspacePressed)
                {
                    ordersgridview.DataSource = originalData.Clone(); // Show empty table but no message
                }
                else
                {
                    MessageBox.Show("No matching data found. Please check your input.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ordersgridview.DataSource = originalData.Clone();
                }
                isBackspacePressed = false; // Reset flag after handling

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
    }
}
