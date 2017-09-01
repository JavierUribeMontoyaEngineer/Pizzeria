using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructures.UOW
{
    public interface IUow:IDisposable
    {
        int SaveChanges();
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
    public class UOW<T>
    {
        public UOW(IUow uow)
        {
            this.Respository = uow.Set<T>();
        }
        public IDbSet<T> Respository {get;privat set; }
    }
}
