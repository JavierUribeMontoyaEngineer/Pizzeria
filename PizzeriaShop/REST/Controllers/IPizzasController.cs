using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace REST.Controllers
{
    public interface IPizzasController
    {
        IEnumerable<Pizza> Get();
        Pizza Get(int id);
        void Post([FromBody]Pizza pizza);
        void Put(int id, [FromBody]Pizza pizza);
    }
}
