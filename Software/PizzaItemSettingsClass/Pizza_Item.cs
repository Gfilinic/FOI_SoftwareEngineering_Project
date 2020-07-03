using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaItemSettingsClass
{
    class Pizza_Item
    {
        public int Id_Ingredient { get; set; }
        public int Id_Pizza { get; set; }

        Pizza_Item(int id_ingredient, int id_pizza)
        {
            Id_Ingredient = id_ingredient;
            Id_Pizza = id_pizza;
        }
    }
}
