namespace web.Repositories;

public interface IRepository<T, TKey>
{
    public void Add(T item);
    public List<T> GetAll();
    public T GetByKey(TKey key);
    public void Remove(TKey key);
    public void Update(T item);
}