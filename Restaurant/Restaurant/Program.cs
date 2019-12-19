using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<string> Categories { get; set; }
        public DateTime DateAdded { get; set; }
        public MenuItem(string name, string description, double price, List<string> categories, DateTime added)
        {
            Name = name;
            Description = description;
            Price = price;
            Categories = categories;
            DateAdded = added;
        }
    }

    public class Menu
    {
        public string Name { get; set; }
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu(string name, List<MenuItem> items, DateTime updated)
        {
            Name = name;
            Items = items;
            LastUpdated = updated;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            MenuItem pasta = new MenuItem(
                "Pasta Carbanara",
                "The one with the peas",
                13.99,
                new List<string>() { "entree", "dinner" },
                new DateTime());

            MenuItem bananasFoster = new MenuItem(
                "Bananas Foster",
                "Better than a split",
                8.99,
                new List<string>() { "dessert" },
                new DateTime());

            MenuItem blondie = new MenuItem(
                "Blondie",
                "A brownie with caramel cake",
                8.99,
                new List<string>() { "dessert" },
                new DateTime());

            Menu resMenu = new Menu(
                "Papa Vitos",
                new List<MenuItem>() { pasta, bananasFoster, blondie },
                new DateTime());

            Console.WriteLine("Restaurant name: " + resMenu.Name);

            Console.WriteLine(bananasFoster.Name + " " + bananasFoster.Price);

            resMenu.Items[1].Price = 11.99;

            Console.WriteLine(bananasFoster.Name + " " + bananasFoster.Price);
            Console.WriteLine(resMenu.Items[1].Name + " " + resMenu.Items[1].Price);



        }
    }
}
