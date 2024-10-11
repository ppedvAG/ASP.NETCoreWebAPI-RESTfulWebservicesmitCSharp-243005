using Microsoft.EntityFrameworkCore;
using VehicleManagement.Data;

namespace VehicleApi.Test
{
    internal class TestDatabase
    {
        private const string ConnectionString = "Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=VehicleTests;Integrated Security=True;Encrypt=False";

        public TestDatabase()
        {
            using (var context = CreateDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.Migrate();

                context.SaveChanges();
            }
        }

        public VehicleDbContext CreateDbContext()
        {
            var builder = new DbContextOptionsBuilder<VehicleDbContext>()
                .UseSqlServer(ConnectionString);
            return new VehicleDbContext(builder.Options);
        }
    }
}
