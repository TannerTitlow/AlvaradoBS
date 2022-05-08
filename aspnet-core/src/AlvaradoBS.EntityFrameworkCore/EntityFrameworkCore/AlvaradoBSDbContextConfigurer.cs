using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AlvaradoBS.EntityFrameworkCore
{
    public static class AlvaradoBSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AlvaradoBSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AlvaradoBSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
