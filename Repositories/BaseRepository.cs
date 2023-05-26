using System.Linq.Expressions;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace WDA_PE.Repositories;

public abstract class BaseRepository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _context;

    protected BaseRepository(AppDbContext context)
    {
        _context = context;
    }

    public virtual IQueryable<T> Get(Expression<Func<T, bool>>? expression = null, int size = 10, int page = 0)
    {
        if (expression == null)
        {
            return _context.Set<T>().Skip(page).Take(size).AsQueryable();
        }

        return _context.Set<T>().Where(expression).Skip(page).Take(size).AsQueryable();
    }
}