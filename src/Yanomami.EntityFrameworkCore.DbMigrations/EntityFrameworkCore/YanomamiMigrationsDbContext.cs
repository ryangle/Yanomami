using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Yanomami.EntityFrameworkCore
{
    /* This DbContext is only used for database migrations.
     * It is not used on runtime. See YanomamiDbContext for the runtime DbContext.
     * It is a unified model that includes configuration for
     * all used modules and your application.
     */
    public class YanomamiMigrationsDbContext : AbpDbContext<YanomamiMigrationsDbContext>
    {
        public YanomamiMigrationsDbContext(DbContextOptions<YanomamiMigrationsDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            /* Configure your own tables/entities inside the ConfigureYanomami method */

            builder.ConfigureYanomami();
        }
    }
}