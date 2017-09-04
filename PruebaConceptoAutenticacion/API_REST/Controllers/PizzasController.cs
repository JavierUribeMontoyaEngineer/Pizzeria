﻿using PruebaConceptoAutenticacion.Cors;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using Infraestructures.UOW;

namespace API_REST.Controllers
{

    public class MyController : ApiController
    {

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
    [AllowCrossSite]
    public class PizzasController : ApiController
    {
        private PizzaService _pizzaService { get; set; }
        public PizzasController()
        {
            var context = new PizzaShopContext();
            var iuow = new UnitOfWork();
            _pizzaService = new PizzaService(context, iuow);
        }
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
            return _pizzaService.GetAllPizzas();
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
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

        }

        // DELETE api/pizzas/2
        //public void Delete(int id)
        //{
        //}
    }
}
