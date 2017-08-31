using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizzas{ get; set; }
    }
}
