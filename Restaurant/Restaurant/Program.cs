﻿using System;
using System.Collections.Generic;
using System.Linq;

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
        public bool IsNew(DateTime fromWhen)
        {
            if (DateTime.Compare(fromWhen, DateAdded) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            string str = "";

            str += Name + " Menu\n " + String.Join("\n--------\n", Categories);
            //str += Name + " -- " + Description + "\nPrice: $" + Price + "\nCategories: " + " String.Join(", ", Categories);

            return str;
        }

        public override bool Equals(object obj)
        {
            MenuItem itemObj;

            if (obj == null || (obj.GetType() != this.GetType()))
            {
                return false;
            }
            itemObj = obj as MenuItem;
            return itemObj.Name == this.Name;
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
            if (items == null)
            {
                this.Items = items;
            }

            LastUpdated = updated;
        }

        public void AddMenuItem(MenuItem item)
        {
            DateTime now = DateTime.Now;
            if (item == null)
            {
                return;
            }
            Items.Add(item);
            LastUpdated = now;
            item.DateAdded = now;
        }

        public bool RemoveMenuItem(MenuItem item)
        {

            if (item == null)
            {
                return false;
            }
            Items.Remove(item);
            LastUpdated = DateTime.Now;
            return true;
        }
        public override string ToString()
        {
            string str = "";

            str += Name + " Menu\n " + String.Join("\n--------\n", Items);
            //str += Name + " -- " + Description + "\nPrice: $" + Price + "\nItems: " + " String.Join(", ", Items);

            return str;
        }

        public override bool Equals(object obj)
        {
            Menu menuObj;

            if (obj == null || (obj.GetType() != this.GetType()))
            {
                return false;
            }
            menuObj = obj as Menu;

            return menuObj.Name == this.Name && 
                menuObj.Items.SequenceEqual(this.Items);
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            MenuItem pasta = new MenuItem(
                "Pasta Carbonara",
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
                new List<MenuItem>() { pasta, bananasFoster, blondie }, new DateTime());
            Console.WriteLine("Restaurant name: " + resMenu.Name);

            Console.WriteLine(bananasFoster);
            Console.WriteLine(bananasFoster.Equals(pasta));
            Console.WriteLine(bananasFoster.Equals(new MenuItem("Bananas Foster", "blah", 5, null, DateTime.Now)));

            resMenu.Items[1].Price = 11.99;

            Console.WriteLine(bananasFoster.Name + " " + bananasFoster.Price);
            Console.WriteLine(resMenu.Items[1].Name + " " + resMenu.Items[1].Price);
        }
    }

}
