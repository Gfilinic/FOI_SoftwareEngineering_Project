using DataBase;
using IngredientSettingsClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngredientSettingsClass
{
    public class Ingredient
    {
        public int Id_ingredient { get; set; }
        public string Name { get; set; }
        public Image IngredientImage { get; set; }
        public decimal Selling_price_per_unit { get; set; }
        public Measurement Measurement { get; set; }
        public int Unit_numbers { get; set; }

        public Ingredient(int id_ingredient, string name, Image ingredientImage, decimal selling_price_per_unit, Measurement measurement, int unit_numbers)
        {
            Id_ingredient = id_ingredient;
            Name = name;
            IngredientImage = ingredientImage;
            Selling_price_per_unit = selling_price_per_unit;
            Measurement = measurement;
            Unit_numbers = unit_numbers;
        }

    }
}

