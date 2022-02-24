using System.Threading.Tasks;

namespace TS.Common
{
    public interface IHandleEventValidation<in T>
        where T : Event
    {
        Task Validate(T toExecute);
    }
}
