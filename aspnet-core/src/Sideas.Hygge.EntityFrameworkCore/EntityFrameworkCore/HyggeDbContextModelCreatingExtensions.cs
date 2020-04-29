using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Sideas.Hygge.EntityFrameworkCore
{
    public static class HyggeDbContextModelCreatingExtensions
    {
        public static void ConfigureHygge(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(HyggeConsts.DbTablePrefix + "YourEntities", HyggeConsts.DbSchema);

            //    //...
            //});
        }
    }
}