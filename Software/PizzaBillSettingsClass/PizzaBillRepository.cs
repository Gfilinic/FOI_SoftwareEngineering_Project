using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBillSettingsClass
{
    public class PizzaBillRepository
    {
        public void AddPizzaBillInDB(int id_bill, int id_pizza, int quantity)
        {
            string SQLcommand = $"INSERT INTO [Pizza_bill] (id_bill, id_pizza, quantity) VALUES ('{id_bill}','{id_pizza}','{quantity}');";

            DataBaseI.Instance.Connect();
            DataBaseI.Instance.ExecuteCommand(SQLcommand);
            DataBaseI.Instance.Disconnect();
        }

    }
}
