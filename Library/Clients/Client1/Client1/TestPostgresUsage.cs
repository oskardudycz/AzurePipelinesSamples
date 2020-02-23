using Npgsql;
using Postgres.NET;

namespace Client1
{
    public class TestPostgresUsage
    {
        private readonly SchemaUpdater schemaUpdater;

        public TestPostgresUsage(string connectionString)
        {
            schemaUpdater = new SchemaUpdater(new NpgsqlConnection(connectionString));
        }
        public int Use()
        {
            return schemaUpdater.CreateTable("test");
        }
    }
}
