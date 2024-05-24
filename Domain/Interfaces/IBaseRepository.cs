
namespace Domain.Interfaces
{
    public interface IBaseRepository <T> where T : class
    {
        T? Get<TId>(TId id);
        List<T> Get();
        T Add(T entity);
    }
}
