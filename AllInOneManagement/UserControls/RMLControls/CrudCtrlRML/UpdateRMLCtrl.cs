using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem.UserControls.RawMaterialLedgerControls.CrudControlsRawMaterialsLedger
{
    public partial class UpdateRawMaterialsLedgerControl : UserControl
    {
        int Id;
        decimal? Amount;
        string? PName;
        public UpdateRawMaterialsLedgerControl(int id, decimal? amount, string? name)
        {
            InitializeComponent();
            Amount = amount.HasValue ? Math.Abs(amount.Value) : (decimal?)null;
            PName = name;
            Id = id;
            txtPName.Text = PName;
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

        private void ClearLeadgerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ClearLeadgerCheckBox.Checked)
            {
                txtAmount.Text = Amount.ToString();
                txtPName.Text = PName;
                txtAmount.ReadOnly = true;
            }
            else
            {
                txtAmount.Text = string.Empty;
                txtPName.Text = PName;
                txtAmount.ReadOnly = false;
            }
        }

        private async void btnClear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter a valid amount to clear the ledger", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                await ClearLedger(Id, DatePicker.Value, decimal.Parse(txtAmount.Text));
            }
        }

        private async Task ClearLedger(int LedgerId, DateTime Date, decimal? Amount = null)
        {

            try
            {
                using (SqlConnection conn = new(DatabaseOperation.GetConnectionString()))
                {
                    await conn.OpenAsync();
                    using (SqlCommand cmd = new("ClearProviderLedger", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@LedgerID", LedgerId);
                        cmd.Parameters.AddWithValue("DateNow", Date);

                        // Handle null Amount
                        if (Amount.HasValue)
                            cmd.Parameters.AddWithValue("@Amount", Amount.Value);
                        else
                            cmd.Parameters.AddWithValue("@Amount", DBNull.Value); // Pass NULL to SQL

                        int result = await cmd.ExecuteNonQueryAsync();
                        if (result > 0)
                        {
                            MessageBox.Show("Ledger cleared successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Error In Clearing Ledger. Plz Check Your Input!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing ledger: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
