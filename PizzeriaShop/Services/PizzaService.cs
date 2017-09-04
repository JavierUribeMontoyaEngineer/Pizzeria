using Infraestructures.UOW;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    
    public class PizzaService : BaseService, IPizzaService
    {
        private readonly IUow _unitOfWork;

        public PizzaService( IUow unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreatePizza(Pizza pizza)
        {
            _unitOfWork.Set<Pizza>().Add(pizza);
            _unitOfWork.SaveChanges();
        }

        public Pizza GetPizza(int id)
        {
            return _unitOfWork.Set<Pizza>().Find(id);
        }

        public IEnumerable<Pizza> GetAllPizzas()
        {
            IQueryable<Pizza> query = _unitOfWork.Set<Pizza>();
            return query.ToList();
        }

        public void Update(Pizza pizzaUpdate)
        {
            _unitOfWork.Set<Pizza>().Attach(pizzaUpdate);
            _unitOfWork.SetModified(pizzaUpdate);
        }
    }
}
