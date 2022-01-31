using System.Threading.Tasks;

namespace TS.Common
{
    public interface IProcessEvents<TEvent>
    where TEvent : Event
    {
        Task Process(TEvent persistEvent);
        Task<TEvent[]> All();
    }
}