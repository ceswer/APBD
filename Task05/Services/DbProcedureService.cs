using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Task05.Exceptions;
using Task05.Models;

namespace Task05.Services
{
    public class DbProcedureService : IDbProcedureService
    {
        //private readonly string connectionString = @"Data Source=COMPUTER;Initial Catalog=APBD;Integrated Security=True";
        private readonly string connectionString = @"Data Source=db-mssql;Initial Catalog=s20363;Integrated Security=True";

        public async Task<int> AddProductToWarehouseAsync(ProductWarehouse productWarehouse)
        {
            int idProductWarehouse = 0;

            using var connection = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("AddProductToWarehouse", connection);

            var transaction = (SqlTransaction) await connection.BeginTransactionAsync();
            cmd.Transaction = transaction;

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IdProduct", productWarehouse.IdProduct);
                cmd.Parameters.AddWithValue("IdWarehouse", productWarehouse.IdWarehouse);
                cmd.Parameters.AddWithValue("Amount", productWarehouse.Amount);
                cmd.Parameters.AddWithValue("CreatedAt", productWarehouse.CreatedAt);

                await connection.OpenAsync();
                int rowsChanged = await cmd.ExecuteNonQueryAsync();

                if (rowsChanged < 1) throw new NoResultException();

                await transaction.CommitAsync();
            } catch (Exception)
            {
                await transaction.RollbackAsync();
                throw new Exception();
            }

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TOP 1 IdProductWarehouse FROM Product_Warehouse ORDER BY IdProductWarehouse DESC";

            using var reader = await cmd.ExecuteReaderAsync();

            await reader.ReadAsync();
            if (await reader.ReadAsync())
                idProductWarehouse = int.Parse(reader["IdProductWarehouse"].ToString());
            await reader.CloseAsync();

            await connection.CloseAsync();

            return idProductWarehouse;
        }
    }
}
