using System;

namespace Model
{
    public class Ingredient
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }

        public Ingredient()
        {
            Id = Guid.NewGuid();
        }

    }
}