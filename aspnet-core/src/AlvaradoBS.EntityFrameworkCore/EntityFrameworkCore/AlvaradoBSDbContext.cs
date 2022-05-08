using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AlvaradoBS.Authorization.Roles;
using AlvaradoBS.Authorization.Users;
using AlvaradoBS.MultiTenancy;

namespace AlvaradoBS.EntityFrameworkCore
{
    public class AlvaradoBSDbContext : AbpZeroDbContext<Tenant, Role, User, AlvaradoBSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AlvaradoBSDbContext(DbContextOptions<AlvaradoBSDbContext> options)
            : base(options)
        {
        }
    }
}
