using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using Infraestructures.UOW;

namespace REST.Controllers
{
    public class PizzasController : ApiController, IPizzasController
    {
        public IPizzaService _pizzaService { get; set; }

        private void generatePizza()
        {
            var ingredients = new List<Ingredient>()
                {
                    new Ingredient{ Name="Queso",Price = 4},
                    new Ingredient{ Name="Queso",Price = 8}

                };
            var pizza = new Pizza(Guid.NewGuid())
            {
                Name = "Margarita"
            };
            pizza.Ingredients = ingredients;
            _pizzaService.CreatePizza(pizza);
        }

        public PizzasController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
            //Este metodo es para rellenar la BD con alguna piza hecha de testeo
            //generatePizza();
        }

        // GET api/pizzas
        public IEnumerable<Pizza> Get()
        {
            return  _pizzaService.GetAllPizzas();
          
        }

        // GET api/pizzas/2
        public Pizza Get(int id)
        {
            return _pizzaService.GetPizza(id);
        }

        // POST api/pizzas
        public void Post([FromBody]Pizza pizza)
        {
            _pizzaService.CreatePizza(pizza);
        }

        // PUT api/pizzas/2
        public void Put(int id, [FromBody]Pizza pizza)
        {
            _pizzaService.Update(pizza);
        }
     
    }
}
