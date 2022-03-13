namespace TS.Common
{
    public interface IWork
    {
        IUnitOfWork Start();
    }

    public interface IEventWork : IWork
    {

    }
}
