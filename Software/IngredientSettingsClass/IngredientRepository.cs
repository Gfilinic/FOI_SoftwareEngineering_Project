using DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngredientSettingsClass
{
    public class IngredientRepository
    {
        public IngredientRepository()
        {

        }

        public int CheckIfIngredientExist(string ingredient)
        {
            int id = 0;
            string SQLcommand = $"SELECT id_ingredient, name FROM [Ingredient] WHERE name ='{ingredient}';";

            DataBaseI.Instance.Connect();
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                string nameDB = dataReader["name"].ToString();
                if (nameDB.ToLower() == ingredient.ToLower())
                {
                    id = int.Parse(dataReader["id_ingredient"].ToString());
                    break;
                }
            }
            dataReader.Close();
            DataBaseI.Instance.Disconnect();
            return id;
        }
        public void AddNewIngredientToDatabase(string name, decimal selling_price_per_unit, int unit_numbers, string imagePath,int id_measurement)
        {
            int idImage = AddIngredientImageToDatabase(imagePath);
            string SQLcommand = $"INSERT INTO [Ingredient] (name, selling_price_per_unit, unit_numbers, id_measurement, id_image) VALUES ('{name}','{selling_price_per_unit}','{unit_numbers}','{id_measurement}','{idImage}');";
            DataBaseI.Instance.Connect();
            DataBaseI.Instance.ExecuteCommand(SQLcommand);
            DataBaseI.Instance.Disconnect();
        }
        public void ModIngredientToDatabase(string name, decimal selling_price_per_unit, int unit_numbers, string imagePath, int id_measurement)
        {
            if (imagePath != null)
            {
                string SQLcommand1 = $"SELECT id_image FROM [Ingredient] WHERE id_ingredient ='{CheckIfIngredientExist(name)}';";
                

                DataBaseI.Instance.Connect();
                int idOldImage = int.Parse(DataBaseI.Instance.GetValue(SQLcommand1).ToString());
                DataBaseI.Instance.Disconnect();

                int idNewImage = AddIngredientImageToDatabase(imagePath);

                
                string SQLcommand2 = $"UPDATE [Ingredient] SET selling_price_per_unit = TRY_CONVERT(decimal(5,2),{selling_price_per_unit}) WHERE id_ingredient = '{CheckIfIngredientExist(name)}';";
                string SQLcommand3 = $"UPDATE [Ingredient] SET unit_numbers = '{unit_numbers}' WHERE id_ingredient = '{CheckIfIngredientExist(name)}';";
                string SQLcommand4 = $"UPDATE [Ingredient] SET id_measurement = '{id_measurement}' WHERE id_ingredient = '{CheckIfIngredientExist(name)}';";
                string SQLcommand5 = $"UPDATE [Ingredient] SET id_image = '{idNewImage}' WHERE id_ingredient = '{CheckIfIngredientExist(name)}';";
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
                string SQLcommand2 = $"UPDATE [Ingredient] SET selling_price_per_unit = TRY_CONVERT(decimal(5,2),{selling_price_per_unit}) WHERE id_ingredient = '{CheckIfIngredientExist(name)}';";
                string SQLcommand3 = $"UPDATE [Ingredient] SET unit_numbers = '{unit_numbers}' WHERE id_ingredient = '{CheckIfIngredientExist(name)}';";
                string SQLcommand4 = $"UPDATE [Ingredient] SET id_measurement = '{id_measurement}' WHERE id_ingredient = '{CheckIfIngredientExist(name)}';";
                DataBaseI.Instance.Connect();
                DataBaseI.Instance.ExecuteCommand(SQLcommand2);
                DataBaseI.Instance.ExecuteCommand(SQLcommand3);
                DataBaseI.Instance.ExecuteCommand(SQLcommand4);
                DataBaseI.Instance.Disconnect();

            }
        }


        public int AddIngredientImageToDatabase(string imagePath)
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
        public Ingredient GetIngredient(int ingredient_id)
        {
            Ingredient ingredient_ = new Ingredient(0, null, null, 0, null, 0);
            string SQLcommand = $"SELECT * FROM [Ingredient] WHERE id_ingredient={ingredient_id}";
            List<Ingredient> ingredients = new List<Ingredient>();
            DataBaseI.Instance.Connect();
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                int id_ingredient = (int)dataReader["id_user"];
                string name = dataReader["name"].ToString();
                decimal selling_price_per_unit = (decimal)dataReader["selling_price_per_unit"];
                int unit_number = (int)dataReader["unit_number"];
                int id_measurement = (int)dataReader["id_measurement"];
                int id_image = (int)dataReader["id_image"];

                Image Image = GetImage(id_image);
                Measurement Measurement = GetMeasurement(id_measurement);

                ingredient_ = new Ingredient(id_ingredient, name, Image, selling_price_per_unit, Measurement, unit_number);
            }
            dataReader.Close();
            DataBaseI.Instance.Disconnect();
            return ingredient_;
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

        private Measurement GetMeasurement(int id_measurement)
        {
            Measurement measurement = new Measurement(0, null);
            string SQLcommand = $"SELECT * FROM [Measurement] WHERE id_measurement={id_measurement};";
            DataBaseI.Instance.Connect();
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                measurement = new Measurement(id_measurement, dataReader["measurement"].ToString());
            }
            dataReader.Close();
            DataBaseI.Instance.Disconnect();
            return measurement;
        }
        public int GetIdMeasurement(string Measurement)
        {
            int id = 0;
            string SQLcommand = $"SELECT id_measurement, measurement FROM [Measurement] WHERE measurement='{Measurement}';";

            DataBaseI.Instance.Connect();
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                string MeasurmentDB = dataReader["measurement"].ToString();
                if(MeasurmentDB == Measurement)
                {
                    id = int.Parse(dataReader["id_measurement"].ToString());
                    break;
                }
                    
            }
            dataReader.Close();
            DataBaseI.Instance.Disconnect();
            return id;
        }

        public void DeleteIngredient(Ingredient ingredient)
        {
            string SQLcommand1 = $"DELETE FROM [Ingredient] WHERE id_ingredient ='{ingredient.Id_ingredient}';";
            string SQLcommand2 = $"DELETE FROM [Image] WHERE id_image ='{ingredient.IngredientImage.Id_image}';";
            DataBaseI.Instance.Connect();
            DataBaseI.Instance.ExecuteCommand(SQLcommand1);
            DataBaseI.Instance.ExecuteCommand(SQLcommand2);
            DataBaseI.Instance.Disconnect();
        }
        public List<Ingredient> GetAllIngredient(List<Ingredient> List)
        {
            string SQLcommand = $"SELECT * FROM [Ingredient];";
            DataBaseI.Instance.Connect();
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                List.Add(new Ingredient(int.Parse(dataReader["id_ingredient"].ToString()), dataReader["name"].ToString(), GetImage(int.Parse(dataReader["id_image"].ToString())), decimal.Parse(dataReader["selling_price_per_unit"].ToString()), GetMeasurement(int.Parse(dataReader["id_measurement"].ToString())), int.Parse(dataReader["unit_numbers"].ToString())));
            }
            dataReader.Close();
            DataBaseI.Instance.Disconnect();
            return List;
        }
    }

}