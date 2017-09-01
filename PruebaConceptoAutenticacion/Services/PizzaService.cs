using Infraestructures.UOW;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BaseService:IDisposable
    {
        readonly IDisposable _dispose;
        public BaseService(IDisposable dispose)
        {

        }

        public void Dispose()
        {
            _dispose.Dispose();
        }
    }
    public class PizzaService : BaseService()
    {
        private readonly UnitOfWork _unitOfWork;
        

        public PizzaService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public void CreatePizza(Pizza pizza)
        {
            _unitOfWork.PizzaRepository.Insert(pizza);
            _unitOfWork.Save();
        }

        public Pizza GetPizza(int id)
        {
            return _unitOfWork.PizzaRepository.GetByID(id);
        }

        public IEnumerable<Pizza> GetAllPizzas()
        {
            return _unitOfWork.PizzaRepository.Get(includeProperties: "Pizza");
        }

        public void Update(Pizza pizzaUpdate)
        {
            _unitOfWork.PizzaRepository.Update(pizzaUpdate);
        }

        
    }
}
