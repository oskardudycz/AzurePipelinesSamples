using System;
using Npgsql;
using Xunit;

namespace Postgres.NET.Tests
{
    public class SchemaUpdaterTests
    {
        public static readonly string ConnectionString = Environment.GetEnvironmentVariable("testing_database")
                                                         ?? "Host=localhost;Port=5432;Database=postgres;Username=postgres;password=postgres";

        [Fact]
        public void Test1()
        {

            using(var schemaUpdater = new SchemaUpdater(new NpgsqlConnection(ConnectionString)))
            {
                schemaUpdater.CreateTable("testTable");
            }
            Assert.True(true);
        }
    }
}
