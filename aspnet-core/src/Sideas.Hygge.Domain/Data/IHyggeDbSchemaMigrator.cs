using System.Threading.Tasks;

namespace Sideas.Hygge.Data
{
    public interface IHyggeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
