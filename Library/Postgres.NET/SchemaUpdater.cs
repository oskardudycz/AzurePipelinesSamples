using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Npgsql;

namespace Postgres.NET
{
    public class SchemaUpdater: IDisposable
    {
        private readonly NpgsqlConnection databaseConnection;

        public SchemaUpdater(NpgsqlConnection databaseConnection)
        {
            this.databaseConnection = databaseConnection;
        }

        public int CreateTable(string tableName, params string [] columns)
        {            
            return databaseConnection.Execute(
                $@"CREATE TABLE {tableName} (
                    { Zip("id serial PRIMARY KEY", columns) }
                );");
        }        

        public int AddCoveringIndex(string tableName, string indexName, string[] columns, string [] include)
        {
            return databaseConnection.Execute(
                $"CREATE INDEX {indexName} ON {tableName}({Zip(columns)}) INCLUDE ({Zip(include)});");
        }

        private string Zip(string firstColumn, string [] items)
        {
            return Zip(new []{ firstColumn }.Union(items ?? Array.Empty<string>()));
        }

        private string Zip(IEnumerable<string> items)
        {
            return items?.Count() > 0 ? 
                string.Join(',', items) 
                : string.Empty;
        }


        public void Dispose()
        {
            databaseConnection.Dispose();
        }
    }
}
