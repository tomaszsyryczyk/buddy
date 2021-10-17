using System.Threading.Tasks;

namespace TS.Common
{
    public interface IMediateEvents<TEvent>
    where TEvent : Event
    {
        Task Persist(TEvent persistEvent);
        Task<TEvent[]> All();
    }
}