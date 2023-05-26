using System.Linq.Expressions;

namespace WDA_PE.Repositories;

public interface IRepositoy<T> where T: class
{
    IQueryable<T> Get(Expression<Func<T, bool>>? expression = null, int size = 10, int page = 0);
    Task<T> GetById(Guid Id);
    Task<T> Create(T entity);
    Task<T> Update(T entity);
    Task<bool> Delete(Guid Id);
}