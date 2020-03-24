using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Nuevo.Core.EfInfrastructure
{
    public class BaseRepo<T, Context> where Context : AppEfContext, new() where T : class
    {
        private AppEfContext _context;

        public BaseRepo()
        {
            _context = new Context();
        }
        public bool Add(T t)
        {
            _context.Set<T>().Add(t);
            return _context.SaveChanges() > 0;
        }
        public bool Update(T t)
        {
            _context.Set<T>().Update(t);
            return _context.SaveChanges() > 0;
        }
        public bool Delete(object key)
        {
            var deleted = _context.Set<T>().Find(key);
            _context.Remove(deleted);
            return _context.SaveChanges() > 0;
        }
        public IQueryable<T> List(Expression<Func<T, bool>> condition)
        {
           return _context.Set<T>().Where(condition);
        }
    }
}
