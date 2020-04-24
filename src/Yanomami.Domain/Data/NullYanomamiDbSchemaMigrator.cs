using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Yanomami.Data
{
    /* This is used if database provider does't define
     * IYanomamiDbSchemaMigrator implementation.
     */
    public class NullYanomamiDbSchemaMigrator : IYanomamiDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}