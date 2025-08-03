using Microsoft.Data.SqlClient;
using System.Data;

namespace FactoryManagementSystem
{
    internal class DatabaseOperation
    {
        //private static readonly string connectionString = @"Data Source=SAMIURREHMANTHI\SQLEXPRESS;Initial Catalog=FactoryManagementDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private static readonly string connectionString = @"Data Source = .\SQLEXPRESS;Initial Catalog = FactoryManagementDB; Integrated Security = True; Encrypt=True;Trust Server Certificate=True";
        public static string GetConnectionString()
        {
            return connectionString;
        }
        public static async Task<DataTable> GetTableDataAsync(string tableName, string? condition = null)
        {
            DataTable dataTable = new();

            try
            {
                using (SqlConnection conn = new(connectionString))
                {
                    await conn.OpenAsync();
                    using (SqlCommand cmd = new("GetAllRecords", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TableName", tableName);
                        cmd.Parameters.AddWithValue("@Condition", (object?)condition ?? DBNull.Value); // Handle NULL case

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
            }

            return dataTable;
        }
    }
}
