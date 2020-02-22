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
        public void CreateTable_ShouldSucceed_ForNonEmptyTableName()
        {
            using var schemaUpdater = new SchemaUpdater(new NpgsqlConnection(ConnectionString));
            
            Assert.NotEqual(0, schemaUpdater.CreateTable("testTable"));
        }
    }
}
