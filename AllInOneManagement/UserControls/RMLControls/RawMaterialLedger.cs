using FactoryManagementSystem.UserControls.RawMaterialLedgerControls.CrudControlsRawMaterialsLedger;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem.UserControls.RawMaterialLedgerControls
{
    public partial class RawMaterialLedger : UserControl
    {
        private DataTable RmData = new();
        private DataTable ProviderData = new();
        private DataTable LedgerData = new();
        private DataTable RMClearanceData = new();
        public RawMaterialLedger()
        {
            InitializeComponent();
            LoadProviderAsync().ConfigureAwait(false);
        }

        private async Task LoadProviderAsync()
        {
            try
            {
                ProviderData = await DatabaseOperation.GetTableDataAsync("Providers");


                ProviderGridView.DataSource = ProviderData;
                ProviderGridView.ClearSelection();
                // Set custom column headers
                ProviderGridView.Columns["ProviderID"].HeaderText = "ID";
                ProviderGridView.Columns["ProviderName"].HeaderText = "Name";
                ProviderGridView.Columns["CNIC"].Visible = false;
                ProviderGridView.Columns["Contact"].HeaderText = "Phone";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Providers Data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ProviderGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ProviderGridView.SelectedRows.Count > 0)
            {
                int providerId = Convert.ToInt32(ProviderGridView.SelectedRows[0].Cells["ProviderID"].Value);
                await LoadLedgerAsync(providerId);
            }
        }

        private async Task LoadLedgerAsync(int providerId)
        {
            try
            {
                string condition = $"ProviderID = {providerId}";
                LedgerData = await DatabaseOperation.GetTableDataAsync("ProviderLedger", condition);

                LedgerGridView.DataSource = LedgerData;
                LedgerGridView.ClearSelection();

                // Set custom column headers
                LedgerGridView.Columns["LedgerID"].HeaderText = "Ledger ID";
                LedgerGridView.Columns["ProviderID"].HeaderText = "Provider ID";
                LedgerGridView.Columns["Amount"].HeaderText = "Amount";
                LedgerGridView.Columns["Amount"].DefaultCellStyle.Format = "N2";
                LedgerGridView.Columns["LedgerDate"].HeaderText = "Date";


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Ledger Data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LedgerGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (LedgerGridView.SelectedRows.Count > 0)
            {
                int ledgerId = Convert.ToInt32(LedgerGridView.SelectedRows[0].Cells["LedgerID"].Value);
                await LoadRawMaterialsAsync(ledgerId);
                await LoadRMClearanceLogAsync(ledgerId);
            }
        }

        private async Task LoadRawMaterialsAsync(int ledgerId)
        {
            try
            {
                string condition = $"LedgerID = {ledgerId}";
                RmData = await DatabaseOperation.GetTableDataAsync("RawMaterials", condition);
                RMGridView.DataSource = RmData;
                RMGridView.ClearSelection();
                RMGridView.Columns["RawMaterialID"].HeaderText = "ID";
                RMGridView.Columns["RawMaterialID"].Visible = false;
                RMGridView.Columns["MaterialName"].HeaderText = "Name";
                RMGridView.Columns["Quantity"].HeaderText = "Quantity";
                RMGridView.Columns["PricePerUnit"].HeaderText = "Unit Price";
                RMGridView.Columns["PricePerUnit"].DefaultCellStyle.Format = "N0";
                RMGridView.Columns["TotalPrice"].HeaderText = "Total Price";
                RMGridView.Columns["TotalPrice"].DefaultCellStyle.Format = "N2";
                RMGridView.Columns["DateAdded"].HeaderText = "Date";
                RMGridView.Columns["Description"].HeaderText = "Description";
                RMGridView.Columns["ProviderName"].HeaderText = "Provider Name";
                RMGridView.Columns["ProviderContact"].HeaderText = "Contact";
                RMGridView.Columns["ProviderCNIC"].Visible = false;
                RMGridView.Columns["LedgerID"].HeaderText = "Ledger ID";
                RMGridView.Columns["LedgerID"].Visible = false;
                RMGridView.Columns["ProviderName"].Visible = false;
                RMGridView.Columns["ProviderContact"].Visible = false;
                RMGridView.Columns["ProviderCNIC"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Raw Materials Data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadRMClearanceLogAsync(int ledgerId)
        {
            try
            {
                string condition = $"LedgerID = {ledgerId}";
                RMClearanceData = await DatabaseOperation.GetTableDataAsync("ProviderLedgerClearanceLog", condition);

                LedgerClearanceGridview.DataSource = RMClearanceData;
                LedgerClearanceGridview.ClearSelection();
                LedgerClearanceGridview.Columns["AmountPaid"].DefaultCellStyle.Format = "N1";
                LedgerClearanceGridview.Columns["RemainingBalance"].DefaultCellStyle.Format = "N1";



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Ledger Clearance Data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnClearLedger_Click(object sender, EventArgs e)
        {
            if (ProviderGridView.SelectedRows.Count > 0)
            {
                string? Name = ProviderGridView.SelectedRows[0].Cells["ProviderName"].Value.ToString();

                if (LedgerGridView.SelectedRows.Count > 0)
                {
                    int ledgerId = Convert.ToInt32(LedgerGridView.SelectedRows[0].Cells["LedgerID"].Value);
                    decimal? Amount = Convert.ToDecimal(LedgerGridView.SelectedRows[0].Cells["Amount"].Value);

                    Popup popup = new Popup(new UpdateRawMaterialsLedgerControl(ledgerId, Amount, Name));
                    popup.ShowDialog();
                    await LoadProviderAsync();
                }
                else
                {
                    MessageBox.Show("Please select a ledger to clear", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("Please select a Customer Also to clear", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProviderGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a provider!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (LedgerClearanceGridview.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a clearance entry to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int clearanceLogId = Convert.ToInt32(LedgerClearanceGridview.SelectedRows[0].Cells["ClearanceID"].Value);
                int ledgerId = Convert.ToInt32(LedgerClearanceGridview.SelectedRows[0].Cells["LedgerID"].Value);
                string? providerName = ProviderGridView.SelectedRows[0].Cells["ProviderName"].Value.ToString();

                // Confirmation before deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this clearance entry?",
                                                      "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(DatabaseOperation.GetConnectionString()))
                    {
                        await conn.OpenAsync();
                        using (SqlCommand cmd = new SqlCommand("DeleteProviderLedgerClearance", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ClearanceID", clearanceLogId);
                            cmd.Parameters.AddWithValue("@LedgerID", ledgerId);
                            cmd.Parameters.AddWithValue("@ProviderName", providerName);

                            int affectedRows = await cmd.ExecuteNonQueryAsync();

                            if (affectedRows > 0)
                            {
                                await LoadProviderAsync();
                                await LoadLedgerAsync(ledgerId);
                                await LoadRMClearanceLogAsync(ledgerId);

                                MessageBox.Show("Clearance reversal successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No matching clearance entry found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting clearance entry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
