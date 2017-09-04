using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Infraestructures.UOW
{
    public class UnitOfWork : IUow
    {
        private PizzaShopContext _context;


        public UnitOfWork(PizzaShopContext context)
        {
            _context = context;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return _context.Set<TEntity>();
        }

        public void SetModified<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Entry<TEntity>(entity).State = EntityState.Modified;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
