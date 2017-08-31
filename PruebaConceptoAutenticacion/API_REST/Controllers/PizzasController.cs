using API_REST.Models;
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
    [AllowCrossSite]
    public class PizzasController : ApiController
    {
        public PizzaService _pizzaService{ get; set; }
        // GET api/pizzas
        public IEnumerable<Pizza> Get()
        {        
            var pizzas = _pizzaService.GetAllPizzas();
            return pizzas;
        }

        // GET api/pizzas/2
        public Pizza Get(int id)
        {
            var pizzas = getPizzasBD().Where(p => p.Id == id);
            return pizzas.ToList<Pizza>()[0];
        }

        // POST api/pizzas
        public void Post([FromBody]string value)
        {
        }

        // PUT api/pizzas/2
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/pizzas/2
        public void Delete(int id)
        {
        }
    }
}
