using PruebaConceptoAutenticacion.Cors;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;

namespace API_REST.Controllers
{
    public class PizzasController : ApiController
    {
        public PizzaService _pizzaService = new PizzaService();

        //private List<Pizza> getPizzasBD()
        //{
           
        //    var pizzas = new List<Pizza>()
        //    {               new Pizza()
        //        {
        //            Name = "Margarita",
        //            Ingredients = new List<Ingredient>
        //            {
        //                new Ingredient{Name = "queso"}
        //            }
        //        },
        //        new Pizza()
        //        {
        //            Name = "Napolitana",
        //            Ingredients = new List<Ingredient>
        //            {
        //                new Ingredient{Name = "queso"}
        //            }
        //       }
        //    };
        //    return pizzas;
        //}

        // GET api/pizzas
        public IEnumerable<Pizza> Get()
        {
            return getPizzasBD();
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

        // DELETE api/pizzas/2
        //public void Delete(int id)
        //{
        //}
    }
}
