using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem.UserControls.SummaryControls
{
    public partial class Summary : UserControl
    {
        private DataTable StockoriginalData = new();
        public Summary()
        {
            InitializeComponent();
            LoadDailySummary();
            LoadStockAsync().ConfigureAwait(false);
        }

        private async Task LoadStockAsync()
        {
            try
            {
                StockoriginalData = await DatabaseOperation.GetTableDataAsync("Stock");
                StockGridView.DataSource = StockoriginalData;
                StockGridView.ClearSelection();
                StockGridView.Columns["StockID"].HeaderText = "ID";
                StockGridView.Columns["ProductName"].HeaderText = "Name";
                StockGridView.Columns["Quantity"].HeaderText = "Quantity";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadDailySummary()
        {
            try
            {
                string query = "GetDailySummary";

                using (SqlConnection conn = new(DatabaseOperation.GetConnectionString()))
                {
                    await conn.OpenAsync();
                    using (SqlCommand cmd = new(query, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Date", DateTime.Today);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.Read())
                            {
                                lblInflow.Text = $"Total Inflow: {reader["TotalInflow"]:N0}";
                                lblOutflow.Text = $"Total Outflow: {reader["TotalOutflow"]:N0}";
                                lblNetFlow.Text = $"Net Flow: {reader["NetFlow"]:N0}";
                                lblTotalOrders.Text = $"Total Orders: {reader["TotalOrders"]}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Daily Summary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
