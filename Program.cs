using StackExchange.Redis;
using System;
using Npgsql;

class Program
{
    static void Main(string[] args)
    {
        // Create a Redis ConnectionMultiplexer
        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
        // Get a Redis database
        IDatabase db = redis.GetDatabase();
        // Set a value in Redis
        
        // Get a value from Redis
        string? value = db.StringGet("mykey");
        Console.WriteLine(value);


        var connectionString = "Server=BigLen;Port=5432;Database=locus;User Id=postgres;Password=8352;";

        using var connection = new NpgsqlConnection(connectionString);

        connection.Open();

        // Create a command to retrieve the data from a table
        {
            // Create a command to retrieve the lists of tables
            // var command = new NpgsqlCommand("SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' ORDER BY table_name;", connection);
        }
        var command = new NpgsqlCommand("SELECT * FROM users;", connection);

        // Execute the command
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetValue(i) + " ");
        }
            Console.WriteLine();
        }

        // Close the connection
        connection.Close();

        Console.WriteLine("HALLO");

        // TEST2
    }
}
