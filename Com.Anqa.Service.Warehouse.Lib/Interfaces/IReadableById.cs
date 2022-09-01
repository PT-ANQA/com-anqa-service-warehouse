using System.Threading.Tasks;

namespace Com.Anqa.Service.Warehouse.Lib.Interfaces
{
    public interface IReadByIdable<TModel>
    {
        Task<TModel> ReadById(int id);
    }
}
