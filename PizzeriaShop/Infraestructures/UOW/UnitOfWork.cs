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
        private PizzaShopContext context = new PizzaShopContext();      

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        public IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return context.Set<TEntity>();
        }

        public void SetModified<TEntity>(TEntity entity) where TEntity : class
        {
            context.Entry<TEntity>(entity).State = EntityState.Modified;
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}
