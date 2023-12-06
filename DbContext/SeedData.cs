using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaTuto.Data;

namespace PizzaTuto.DbContext
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext db)
        {
            var pizzaSpecials = new PizzaSpecial[]
            {
                new PizzaSpecial()
                {
                    Name = "Pizza Margherita",
                    Description = "Margherita or Neapolitan pizza is one of the oldest Italian pizzas along with Marinara.",
                    Price = 9.99m,
                    Image = "img/pizzaSpicial/spicial1.jpeg",
                },
                   new PizzaSpecial()
                {
                    Id = 2,
                    Name = "Pizza Reine",
                    Description = "This is one of the favorite pizzas of the French and Europeans in general. The Queen or Regina pizza is none other than a Margherita to which generous slices of ham and fresh mushrooms are added.",
                    Price = 11.99m,
                    Image = "img/pizzaSpicial/spicial2.jpeg",
                },
                    new PizzaSpecial()
                {
                    Id = 3,
                    Name = "Four cheese pizza",
                    Description = "The Quattro Formaggi pizza has a thinner and crispier crust than the Margherita. It is for this reason that it is assumed that it originated in Rome. As its name suggests, it is made up of 4 different cheeses. There you can find the essential mozzarella and grated cheese like Emmental or Comté.",
                    Price = 10.99m,
                    Image = "img/pizzaSpicial/spicial3.jpeg",
                },
                    new PizzaSpecial()
                {
                    Id = 4,
                    Name = "Pizza 4 Seasons",
                    Description = "The 4 seasons pizza is very popular in Italy, it is called Quattro Stagioni. It refers to the 4 seasons of the year and is made up of 4 different parts. The base always remains tomato and mozzarella. We then find on the other parts in turn, black olives, artichokes and ham.",
                    Price = 13.99m,
                    Image = "img/pizzaSpicial/spicial4.jpeg",
                },
                    new PizzaSpecial()
                {
                    Id = 5,
                    Name = "The Calzone",
                    Description = "The Calzone is a classic pizza that is folded in half. It is therefore more voluminous and more delicious.",
                    Price = 8.99m,
                    Image = "img/pizzaSpicial/spicial5.jpeg",
                },
                    new PizzaSpecial()
                {
                    Id = 6,
                    Name = "Pepperoni Pizza",
                    Description = "Pepperoni is the most successful pizza outside of Italy and even Europe. In fact, this pizza was not born in Italy,",
                    Price = 12.99m,
                    Image = "img/pizzaSpicial/spicial6.jpeg",
                },
            };

            db.PizzaSpecials.AddRange(pizzaSpecials);
            db.SaveChanges();
        }
    }
}
