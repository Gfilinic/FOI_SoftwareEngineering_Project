using DataBase;
using IngredientSettingsClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PizzaItemSettingsClass
{
    public class PizzaItemRepository
    {
        public PizzaItemRepository()
        {

        }

        public void AddPizzaItemsInDB(List<Ingredient> Ingredientlist, int id_pizza)
        {
            DataBaseI.Instance.Connect();
            foreach (var ingredient in Ingredientlist)
            {
                string SQLcommand = $"INSERT INTO [Pizza_items] (id_ingredient, id_pizza) VALUES ('{ingredient.Id_ingredient}','{id_pizza}');";
                DataBaseI.Instance.ExecuteCommand(SQLcommand);
            }

            DataBaseI.Instance.Disconnect();
        }

        public void DeletePizzaItems(int id_pizza)
        {
            List<Pizza_Item> PizzaItems = new List<Pizza_Item>();
            string SQLcommand = $"DELETE * FROM [Pizza_items] WHERE id_pizza = '{id_pizza}'";
            DataBaseI.Instance.Connect();
            DataBaseI.Instance.ExecuteCommand(SQLcommand);
            DataBaseI.Instance.Disconnect();
        }
    }
}
