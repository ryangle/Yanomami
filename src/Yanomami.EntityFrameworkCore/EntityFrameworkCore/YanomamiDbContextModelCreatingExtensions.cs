using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Yanomami.EntityFrameworkCore
{
    public static class YanomamiDbContextModelCreatingExtensions
    {
        public static void ConfigureYanomami(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Customer>(b =>
            {
                b.ToTable(YanomamiConsts.DbTablePrefix + "Customers", YanomamiConsts.DbSchema);
            });
        }
    }
}