using System.Threading.Tasks;

namespace Yanomami.Data
{
    public interface IYanomamiDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
