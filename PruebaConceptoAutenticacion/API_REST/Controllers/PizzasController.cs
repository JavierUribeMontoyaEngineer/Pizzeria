using API_REST.Models;
using PruebaConceptoAutenticacion.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_REST.Controllers
{
    [AllowCrossSite]
    public class PizzasController : ApiController
    {
        //TODO eliminar este metodo y usar el de la BD real
        private List<Pizza> getPizzasBD()
        {
            var pizzas = new List<Pizza>()
            {
                new Pizza()
                {
                    Id = 1,
                    Name = "Margarita"

                },
                new Pizza()
                {
                    Id = 2,
                    Name = "Napolitana"
                }
            };
            return pizzas;
        }
        
        // GET api/pizzas
        public IEnumerable<Pizza> Get()
        {        
            return getPizzasBD();
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
