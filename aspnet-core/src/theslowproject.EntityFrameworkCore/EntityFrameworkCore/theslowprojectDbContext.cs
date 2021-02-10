using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using theslowproject.Authorization.Roles;
using theslowproject.Authorization.Users;
using theslowproject.MultiTenancy;

namespace theslowproject.EntityFrameworkCore
{
    public class theslowprojectDbContext : AbpZeroDbContext<Tenant, Role, User, theslowprojectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public theslowprojectDbContext(DbContextOptions<theslowprojectDbContext> options)
            : base(options)
        {
        }
    }
}
