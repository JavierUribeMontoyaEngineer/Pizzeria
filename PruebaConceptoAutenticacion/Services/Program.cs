using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class Program
    {
        static void Main(string[] args)
        {

            var service = new PizzaService();

            var pizzas = service.GetAllPizzas();
            foreach (var pizza in pizzas)
            {
                Console.WriteLine(pizza.Name);
            }

        }
    }
}
