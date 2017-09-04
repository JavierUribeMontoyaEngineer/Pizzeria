using Infraestructures.UOW;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private PizzaShopContext _pizzaShopContext { get; set; }
        public DbSet<TEntity> _dbSet { get; set; }

        public GenericRepository(PizzaShopContext pizzaShopContext)
        {
            _pizzaShopContext = pizzaShopContext;
            _dbSet = pizzaShopContext.Set<TEntity>();

            IUow xxx = new PizzaShopContext();
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public TEntity GetByID(object id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(TEntity entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _pizzaShopContext.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
