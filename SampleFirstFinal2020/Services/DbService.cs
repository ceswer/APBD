using SampleFirstFinal2020.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SampleFirstFinal2020.Services
{
    public class DbService : IDbService
    {
        private readonly string connectionString = @"Data Source=COMPUTER;Initial Catalog=APBD;Integrated Security=True";
        private readonly string[] columns = { "name", "type", "admissiondate", "lastname" };

        public async Task<IEnumerable<AnimalForGetting>> GetAnimals(string orderBy)
        {
            var animals = new List<AnimalForGetting>();

            using var connection = new SqlConnection(connectionString);
            using var cmd = new SqlCommand();

            cmd.Connection = connection;
            await connection.OpenAsync();

            if (orderBy == null)
                cmd.CommandText = "SELECT Name, Type, AdmissionDate, LastName FROM Animal INNER JOIN Owner ON AnimalForGetting.IdOwner = Owner.IdOwner ORDER BY AdmissionDate DESC";
            else if (!columns.Contains(orderBy.ToLower()) && !orderBy.ToLower().Contains("desc"))
                throw new Exception("Invalid orderBy parameter!");
            else
                foreach (string column in columns)
                    if (orderBy.ToLower().Contains(column) && orderBy.ToLower().Contains("desc"))
                        cmd.CommandText = $"SELECT Name, Type, AdmissionDate, LastName FROM Animal INNER JOIN Owner ON AnimalForGetting.IdOwner = Owner.IdOwner ORDER BY {column} DESC";
                    else if (orderBy.ToLower().Contains(column))
                        cmd.CommandText = $"SELECT Name, Type, AdmissionDate, LastName FROM Animal INNER JOIN Owner ON AnimalForGetting.IdOwner = Owner.IdOwner ORDER BY {column} ASC";

            using var reader = await cmd.ExecuteReaderAsync();

            if (!reader.HasRows) throw new Exception("No rows to show!");

            while (await reader.ReadAsync())
                animals.Add(new AnimalForGetting
                {
                    Name = reader["Name"].ToString(),
                    Type = reader["Type"].ToString(),
                    AdmissionDate = DateTime.Parse(reader["AdmissionDate"].ToString()),
                    LastNameOfOwner = reader["LastName"].ToString()

                });

            return animals;
        }
    }
}
