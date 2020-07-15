using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using DataBase;

namespace DiscountSettingsClass
{
    public class DiscountRepository
    {
        public DiscountRepository() { }

        public int CheckIfDiscountExist(string discount)
        {
            int id = 0;
            string SQLcommand = $"SELECT id_discount, name FROM [Discount] WHERE name ='{discount}';";

            DataBaseI.Instance.Connect();
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                string nameDB = dataReader["name"].ToString();
                if (nameDB.ToLower() == discount.ToLower())
                {
                    id = int.Parse(dataReader["id_discount"].ToString());
                    break;
                }
            }
            dataReader.Close();
            DataBaseI.Instance.Disconnect();
            return id;
        }

        public void AddNewDiscountToDatabase( string name, string description, DateTime date_Time_Begins, DateTime date_Time_Ends, string imagePath)
        {
            int idImage = AddDiscountImageToDatabase(imagePath);
            string format = "yyyy-MM-dd HH:mm:ss";
            string SQLcommand = $"INSERT INTO [Discount] (name, id_image, description, date_time_begins, date_time_ends) VALUES ('{name}','{idImage}','{description}','{date_Time_Begins.ToString(format)}','{date_Time_Ends.ToString(format)}');";
            DataBaseI.Instance.Connect();
            DataBaseI.Instance.ExecuteCommand(SQLcommand);
            DataBaseI.Instance.Disconnect();
        }

        public int AddDiscountImageToDatabase(string imagePath)
        {
            if (imagePath == null)
                return 1;
            else
            {
                byte[] image = null;
                FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                image = br.ReadBytes((int)fs.Length);

                string SQLcommand = "INSERT INTO [Image] VALUES (@image);";
                DataBaseI.Instance.Connect();
                DataBaseI.Instance.ExecuteCommandImageParametar(SQLcommand, image);
                DataBaseI.Instance.Disconnect();
                SQLcommand = $"SELECT MAX(id_image) FROM [Image];";
                DataBaseI.Instance.Connect();
                int idImage = int.Parse(DataBaseI.Instance.GetValue(SQLcommand).ToString());
                DataBaseI.Instance.Disconnect();
                return idImage;
            }
        }

        private Image GetImage(int id_image)
        {
            byte[] image = null;
            Image imageItem = new Image(0, image);
            string SQLcommand = $"SELECT * FROM [Image] WHERE id_image={id_image};";
            DataBaseI.Instance.Connect();
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                image = (byte[])dataReader["image"];
                imageItem = new Image(id_image, image);
            }
            dataReader.Close();
            DataBaseI.Instance.Disconnect();
            return imageItem;
        }


        public Discount GetDiscount(int discount_id)
        {
            Discount discount_ = new Discount(0, null, null, null, default(DateTime), default(DateTime));
            string SQLcommand = $"SELECT * FROM [Discount] WHERE id_discount={discount_id}";
            List<Discount> discounts = new List<Discount>();
            DataBaseI.Instance.Connect();
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                int id_discount = (int)dataReader["id_discount"];
                string name = dataReader["name"].ToString();
                int id_image = (int)dataReader["id_image"];
                string descirption = dataReader["description"].ToString();
                DateTime date_time_begins = DateTime.Parse(dataReader["date_time_begins"].ToString());
                DateTime date_time_ends = DateTime.Parse(dataReader["date_time_ends"].ToString());

                Image Image = GetImage(id_image);
                

                discount_ = new Discount(id_discount, name, Image, descirption, date_time_begins, date_time_ends);
            }
            dataReader.Close();
            DataBaseI.Instance.Disconnect();
            return discount_;
        }



        public void DeleteDiscount(Discount discount)
        {
            string SQLcommand1 = $"DELETE FROM [Discount] WHERE id_discount ='{discount.Id_Discount}';";
            string SQLcommand2 = $"DELETE FROM [Image] WHERE id_image ='{discount.DiscountImage.Id_image}';";
            DataBaseI.Instance.Connect();
            DataBaseI.Instance.ExecuteCommand(SQLcommand1);
            DataBaseI.Instance.ExecuteCommand(SQLcommand2);
            DataBaseI.Instance.Disconnect();
        }



        public List<Discount> GetAllDiscounts()
        {
            List<Discount> List = new List<Discount>();
            string SQLcommand = $"SELECT * FROM [Discount];";
            DataBaseI.Instance.Connect();
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                List.Add(new Discount(int.Parse(dataReader["id_discount"].ToString()), dataReader["name"].ToString(), GetImage(int.Parse(dataReader["id_image"].ToString())), dataReader["description"].ToString(), DateTime.Parse(dataReader["date_time_begins"].ToString()), DateTime.Parse(dataReader["date_time_ends"].ToString())));
            }
            dataReader.Close();
            DataBaseI.Instance.Disconnect();
            return List;
        }


        public bool DateCheck(Discount discount)
        {
            string SQLcommand1 = $"SELECT date_time_begins FROM [Discount] WHERE id_ingredient = '{discount.Id_Discount}';";
            string SQLcommand2 = $"SELECT date_time_ends FROM [Discount] WHERE id_ingredient = '{discount.Id_Discount}';";

            DataBaseI.Instance.Connect();

            DateTime date_time_begins = DateTime.Parse(DataBaseI.Instance.GetValue(SQLcommand1).ToString());
            DateTime date_time_ends = DateTime.Parse(DataBaseI.Instance.GetValue(SQLcommand2).ToString());
            DateTime now = DateTime.Now;
            DataBaseI.Instance.Disconnect();

            if ((date_time_begins < now)&&(now < date_time_ends))
                return true;
            else
                return false;
        }

        public void ModDiscountToDatabase(string name, string description, DateTime date_Time_Begins, DateTime date_Time_Ends, string imagePath)
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            if (imagePath != null)
            {
                string SQLcommand1 = $"SELECT id_image FROM [Discount] WHERE id_discount ='{CheckIfDiscountExist(name)}';";


                DataBaseI.Instance.Connect();
                int idOldImage = int.Parse(DataBaseI.Instance.GetValue(SQLcommand1).ToString());
                DataBaseI.Instance.Disconnect();

                int idNewImage = AddDiscountImageToDatabase(imagePath);


                string SQLcommand2 = $"UPDATE [Discount] SET description = '{description}'WHERE id_discount = '{CheckIfDiscountExist(name)}';";
                string SQLcommand3 = $"UPDATE [Discount] SET date_time_begins = '{date_Time_Begins.ToString(format)}' WHERE id_discount = '{CheckIfDiscountExist(name)}';";
                string SQLcommand4 = $"UPDATE [Discount] SET date_time_ends = '{date_Time_Ends.ToString(format)}' WHERE id_discount = '{CheckIfDiscountExist(name)}';";
                string SQLcommand5 = $"UPDATE [Discount] SET id_image = '{idNewImage}' WHERE id_discount = '{CheckIfDiscountExist(name)}';";
                string SQLcommand6 = $"DELETE FROM [Image] WHERE id_image ='{idOldImage}';";
                DataBaseI.Instance.Connect();
                DataBaseI.Instance.ExecuteCommand(SQLcommand2);
                DataBaseI.Instance.ExecuteCommand(SQLcommand3);
                DataBaseI.Instance.ExecuteCommand(SQLcommand4);
                DataBaseI.Instance.ExecuteCommand(SQLcommand5);
                DataBaseI.Instance.ExecuteCommand(SQLcommand6);
                DataBaseI.Instance.Disconnect();

            }
            else
            {
                string SQLcommand2 = $"UPDATE [Discount] SET description = '{description}'WHERE id_discount = '{CheckIfDiscountExist(name)}';";
                string SQLcommand3 = $"UPDATE [Discount] SET date_time_begins = '{date_Time_Begins.ToString(format)}' WHERE id_discount = '{CheckIfDiscountExist(name)}';";
                string SQLcommand4 = $"UPDATE [Discount] SET date_time_ends = '{date_Time_Ends.ToString(format)}' WHERE id_discount = '{CheckIfDiscountExist(name)}';";
                DataBaseI.Instance.Connect();
                DataBaseI.Instance.ExecuteCommand(SQLcommand2);
                DataBaseI.Instance.ExecuteCommand(SQLcommand3);
                DataBaseI.Instance.ExecuteCommand(SQLcommand4);
                DataBaseI.Instance.Disconnect();

            }
        }
    }
    
}
