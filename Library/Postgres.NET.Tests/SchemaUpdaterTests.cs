using System;
using System.Linq;
using Npgsql;
using Xunit;

namespace Postgres.NET.Tests
{
    public class SchemaUpdaterTests
    {
        private static readonly string ConnectionString
            = Environment.GetEnvironmentVariable("testing_database")
              ?? "Host=localhost;Port=5432;Database=postgres;Username=postgres;password=postgres";

        [Fact]
        public void CreateTable_ShouldSucceed_ForNonEmptyTableName()
        {
            using var schemaUpdater = new SchemaUpdater(new NpgsqlConnection(ConnectionString));

            Assert.NotEqual(0, schemaUpdater.CreateTable("testTable"));
        }

        [Fact]
        public void CreateCovering_ShouldSucceed_ForExistingTableNameAndProperListOfColumns()
        {
            using var schemaUpdater = new SchemaUpdater(new NpgsqlConnection(ConnectionString));
            
            var tableName = "testTableCoveringIndex";
            var columnNames = new [] { "firstColumn", "secondColumn", "thirdColumn" };
            var columns = columnNames.Select(column => $"{column} int").ToArray();
            var include = new [] { "thirdColumn" };

            schemaUpdater.CreateTable(tableName, columns);

            Assert.NotEqual(0, schemaUpdater.AddCoveringIndex(tableName, $"{tableName}_covering_idx", columnNames, include));
        }
    }
}
