using System.Threading.Tasks;

namespace TS.Common
{
    public interface IHandleEventExecution<in T>
        where T : Event
    {
        Task Execute(T toExecute);
    }
}
