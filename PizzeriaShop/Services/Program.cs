using Infraestructures.UOW;
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

            var context = new PizzaShopContext();
            var iuow = new UnitOfWork();
            var pizzaService = new PizzaService(context, iuow);
            var pizzasCreadas = GetPizzasCreadas();
            var pizza1 = new Pizza()
            {
                Name = "Margarita",
                Ingredients = new List<Ingredient>
                    {
                        new Ingredient{Name = "queso"}
                    }
            };
            var pizza2 = new Pizza()
            {
                Name = "Napolitana",
                Ingredients = new List<Ingredient>
                    {
                        new Ingredient{Name = "queso"}
                    }
            };
            pizzaService.CreatePizza(pizza1);
            pizzaService.CreatePizza(pizza2);

            var pizzas = pizzaService.GetAllPizzas();
            foreach (var pizza in pizzas)
            {
                Console.WriteLine(pizza.Name);
            }
            Console.ReadLine();

        }

        private static List<Pizza> GetPizzasCreadas()
        {
            var pizzas = new List<Pizza>()
            {               new Pizza()
                {
                    Name = "Margarita",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient{Name = "queso"}
                    }
                },
                new Pizza()
                {
                    Name = "Napolitana",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient{Name = "queso"}
                    }
               }
            };
            return pizzas;
        }

       

    }
}
