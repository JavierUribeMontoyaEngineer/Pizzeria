using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructures.UOW
{
    public class PizzaShopContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
