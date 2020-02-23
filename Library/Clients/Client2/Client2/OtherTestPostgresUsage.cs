using Npgsql;
using Postgres.NET;

namespace Client1
{
    public class OtherTestPostgresUsage
    {
        private readonly SchemaUpdater schemaUpdater;

        public OtherTestPostgresUsage(NpgsqlConnection connection)
        {
            schemaUpdater = new SchemaUpdater(connection);
        }
        public int Use()
        {
            return schemaUpdater.CreateTable("test");
        }
    }
}
