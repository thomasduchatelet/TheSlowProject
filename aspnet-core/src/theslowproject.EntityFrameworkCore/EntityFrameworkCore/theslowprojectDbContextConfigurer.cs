using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace theslowproject.EntityFrameworkCore
{
    public static class theslowprojectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<theslowprojectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<theslowprojectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
