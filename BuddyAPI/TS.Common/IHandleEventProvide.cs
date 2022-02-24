using System.Threading.Tasks;

namespace TS.Common
{
    public interface IHandleEventProvide<T>
        where T : Event
    {
        Task<T[]> All();
    }
}
