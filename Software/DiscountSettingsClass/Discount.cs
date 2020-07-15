using System;
using DataBase;
using DiscountSettingsClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DiscountSettingsClass
{
    public class Discount
    {
        public int Id_Discount { get; set; }
        public string Name { get; set; }
        public Image DiscountImage { get; set; }
        public string Description { get; set; }
        public DateTime Date_Time_Begins { get; set; }
        public DateTime Date_Time_Ends { get; set; }

        public Discount(int id_Discount, string name, Image discountImage, string description, DateTime date_Time_Begins, DateTime date_Time_Ends)
        {
            Id_Discount = id_Discount;
            Name = name;
            DiscountImage = discountImage;
            Description = description;
            Date_Time_Begins = date_Time_Begins;
            Date_Time_Ends = date_Time_Ends;
        }
    }
}
