using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaSettingsClass
{
    public class Pizza
    {
        public int Id_pizza { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id_image { get; set; }
        public bool Admin_added { get; set; }

        public Pizza(int id_pizza, string name, string descritpion, int id_image, bool admin_added)
        {
            Id_pizza = id_pizza;
            Name = name;
            Description = descritpion;
            Id_image = id_image;
            Admin_added = admin_added;
        }
    }


}
