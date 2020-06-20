using DataBase;
using System;
using System.Collections.Generic;
using System.Text;
using UserSettingsClass;

namespace BillSettingsClass
{
    public class BillRepository
    {
        public int AddNewBill(User user)
        {
            int idBill = 0;
            DateTime DateTime = DateTime.Now;
            string SQLcommand1 = $"INSERT INTO [Bill] (id_worker, id_customer, date_time, total_price_before_tax, total_tax, total_price_after_tax) VALUES ('2','{user.Id}',CURRENT_TIMESTAMP,'0','0','0');";
            string SQLcommand2 = $"SELECT MAX(id_bill) FROM [Bill];";
            DataBaseI.Instance.Connect();
            DataBaseI.Instance.ExecuteCommand(SQLcommand1);
            idBill = int.Parse(DataBaseI.Instance.GetValue(SQLcommand2).ToString());
            DataBaseI.Instance.Disconnect();
            return idBill;
        }
    }
}
