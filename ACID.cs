/*
CREATE TABLE Accounts (
    AccountId INT PRIMARY KEY,
    Balance DECIMAL(10, 2)
);
*/


using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "your_connection_string_here";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Begin a SQL transaction
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    // Assign transaction to command
                    SqlCommand command = connection.CreateCommand();
                    command.Transaction = transaction;

                    // 1. Atomicity: All or nothing
                    Console.WriteLine("Starting transaction...");
                    command.CommandText = "INSERT INTO Accounts (AccountId, Balance) VALUES (1, 1000)";
                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO Accounts (AccountId, Balance) VALUES (2, 2000)";
                    command.ExecuteNonQuery();

                    // 2. Consistency: Invalid operation simulation (uncomment to test rollback)
                    // command.CommandText = "INSERT INTO NonExistingTable VALUES (1)";
                    // command.ExecuteNonQuery();

                    // 3. Isolation: Simulated by locking rows, handled automatically by transactions

                    // Commit transaction
                    transaction.Commit();
                    Console.WriteLine("Transaction committed successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error occurred: {ex.Message}");
                    // Rollback transaction in case of error
                    transaction.Rollback();
                    Console.WriteLine("Transaction rolled back.");
                }
            }

            // 4. Durability: Ensured by SQL Server after commit
            Console.WriteLine("Changes are durable.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
