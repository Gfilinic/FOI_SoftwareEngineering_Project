using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaSettingsClass
{
    public class PizzaRepository
    {
        public PizzaRepository()
        {

        }

        public int AddPizzaInDB()
        {
            int id_pizza;
            string SQLcommand1 = $"INSERT INTO [Pizza] (name, description, id_image, admin_added) VALUES ('Custom Pizza','Custom Pizza','83','0');";
            string SQLcommand2 = $"SELECT MAX(id_pizza)     FROM [Pizza];";
            DataBaseI.Instance.Connect();
            DataBaseI.Instance.ExecuteCommand(SQLcommand1);
            id_pizza = (int)DataBaseI.Instance.GetValue(SQLcommand2);
            DataBaseI.Instance.Disconnect();
            return id_pizza;
        }

        public int AddPizzaInDB(string name, string description, int id_image, bool admin_added)
        {
            int id_pizza;
            string SQLcommand1 = $"INSERT INTO [Pizza] (name, description, id_image, admin_added) VALUES ('{name}','{description}','{id_image}','{admin_added}');";
            string SQLcommand2 = $"SELECT MAX(id_pizza) FROM [Pizza];";
            DataBaseI.Instance.Connect();
            DataBaseI.Instance.ExecuteCommand(SQLcommand1);
            id_pizza = (int)DataBaseI.Instance.GetValue(SQLcommand2);
            DataBaseI.Instance.Disconnect();
            return id_pizza;

        }
    }
}
