using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IPizzaService
    {
        void CreatePizza(Pizza pizza);
        Pizza GetPizza(int id);
        IEnumerable<Pizza> GetAllPizzas();
        void Update(Pizza pizzaUpdate);
       
    }
}
