using System.Threading.Tasks;

namespace Com.Anqa.Service.Warehouse.Lib.Interfaces
{
    public interface ICreateable
    {
        Task<int> Create(object model);
    }
}
