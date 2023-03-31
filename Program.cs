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
        TESTTTTTTTTTTT
    }
}
