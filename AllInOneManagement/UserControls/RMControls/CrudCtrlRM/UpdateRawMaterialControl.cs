using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem.UserControls.RawMaterialsControls.CrudControlsRawMaterial
{
    public partial class UpdateRawMaterialControl : UserControl
    {
        // Declare fields to hold the passed data
        private int _materialID;
        private string? _materialName;
        private int _quantity;
        private decimal _pricePerUnit;
        private decimal _totalPrice;
        private DateTime _dateAdded;
        private string? _description;
        public UpdateRawMaterialControl(int materialID, string? materialName, int quantity, decimal pricePerUnit, decimal totalPrice, DateTime dateAdded, string? description)
        {
            InitializeComponent();
            _materialID = materialID;
            _materialName = materialName;
            _quantity = quantity;
            _pricePerUnit = pricePerUnit;
            _totalPrice = totalPrice;
            _dateAdded = dateAdded;
            _description = description;

            // Populate the controls (e.g., textboxes) with the passed values
            txtRawMName.Text = _materialName;
            txtRawMQuantity.Text = _quantity.ToString();
            txtRawMprice.Text = _pricePerUnit.ToString();
            RawMDatePicker.Value = _dateAdded;
            txtRawMdescription.Text = _description;
        }


        private async Task UpdateRawMaterialAsync(int materialID, string newMaterialName, int newQuantity, decimal newPricePerUnit, DateTime newDateAdded, string? newDescription, string? oldDescription, decimal oldTotalAmount)
        {
            // Ensure we have valid input data
            if (string.IsNullOrEmpty(newMaterialName) || string.IsNullOrEmpty(newDescription) || newQuantity <= 0 || newPricePerUnit <= 0)
            {
                MessageBox.Show("Please provide valid input values.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseOperation.GetConnectionString()))
                {
                    await conn.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand("UpdateRawMaterialByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@MaterialID", materialID);
                        cmd.Parameters.AddWithValue("@NewMaterialName", newMaterialName);
                        cmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
                        cmd.Parameters.AddWithValue("@NewPricePerUnit", newPricePerUnit);
                        cmd.Parameters.AddWithValue("@NewDateAdded", newDateAdded);
                        cmd.Parameters.AddWithValue("@NewDescription", newDescription);
                        cmd.Parameters.AddWithValue("@OldDescription", oldDescription);
                        cmd.Parameters.AddWithValue("@OldTotalAmount", oldTotalAmount);

                        // Declare output parameter for affected rows
                        SqlParameter outputAffectedRows = new SqlParameter("@AffectedRows", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputAffectedRows);

                        // Execute the procedure asynchronously
                        int result = await cmd.ExecuteNonQueryAsync();

                        // Retrieve the affected rows count from the output parameter
                        int affectedRows = (int)outputAffectedRows.Value;

                        // Check if the update was successful
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Raw material updated successfully.");
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
            // Capture the updated values entered in the form
            string newMaterialName = txtRawMName.Text;
            int newQuantity = int.Parse(txtRawMQuantity.Text);
            decimal newPricePerUnit = decimal.Parse(txtRawMprice.Text);
            DateTime newDateAdded = RawMDatePicker.Value;
            string newDescription = txtRawMdescription.Text;

            // Calculate the new total price (Quantity * PricePerUnit)
            decimal newTotalPrice = newQuantity * newPricePerUnit;

            // Get the old values (can be passed from the grid or stored control)
            string? oldDescription = _description;  // The old description passed when loading the user control
            decimal oldTotalAmount = _totalPrice; // The old total price passed when loading the user control

            // Now call the method to update the database
            await UpdateRawMaterialAsync(_materialID, newMaterialName, newQuantity, newPricePerUnit, newDateAdded, newDescription, oldDescription, oldTotalAmount);
        }
    }
}
