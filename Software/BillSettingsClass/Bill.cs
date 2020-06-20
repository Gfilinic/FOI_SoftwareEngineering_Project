using System;

namespace BillSettingsClass
{
    public class Bill
    {
        public int Id_Bill { get; set; }
        public int Id_Worker { get; set; }
        public int Id_Customer { get; set; }
        public DateTime Date_Time { get; set; }
        public decimal Total_Price_Before_Tax { get; set; }
        public decimal Total_Tax { get; set; }
        public decimal Total_Price_After_Tax { get; set; }

        /// <summary>
        /// Constructor used for fetching 1 user.
        /// </summary>
        public Bill(int id_Bill, int id_Worker, int id_Customer, DateTime date_Time, decimal total_Price_Before_Tax, decimal total_Tax, decimal total_Price_After_Tax)
        {
            Id_Bill = id_Bill;
            Id_Worker = id_Worker;
            Id_Customer = id_Customer;
            Date_Time = date_Time;
            Total_Price_Before_Tax = total_Price_After_Tax;
            Total_Tax = total_Tax;
            Total_Price_After_Tax = total_Price_After_Tax;
        }

        public Bill()
        {

        }
    }
}
