using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace UserSettingsClass
{
    public class UserRepository
    {
        public UserRepository()
        {

        }
        public int CheckIfUsernameExists(string username)
        {
            int id = 0;
            string SQLcommand = $"SELECT id_user, username FROM [User] WHERE username='{username}';";
            DataBaseI.Instance.Connect();
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                string usernameDB = dataReader["username"].ToString();
                if (usernameDB.ToLower() == username.ToLower())
                {
                    id = int.Parse(dataReader["id_user"].ToString());
                    break;
                }
            }
            dataReader.Close();
            DataBaseI.Instance.Disconnect();
            return id;
        }

        public int CheckIfEmailExists(string email)
        {
            int id = 0;
            string SQLcommand = $"SELECT id_user, email FROM [User] WHERE email='{email}';";
            DataBaseI.Instance.Connect();
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                string emailDB = dataReader["email"].ToString();
                if (emailDB.ToLower() == email.ToLower())
                {
                    id = int.Parse(dataReader["id_user"].ToString());
                    break;
                }
            }
            dataReader.Close();
            DataBaseI.Instance.Disconnect();
            return id;
        }

        public void AddNewUserToDatabase(string name, string surname, string username, string password, string email, string city, int zipcode, string adress, string imagePath)
        {
            int idImage = AddUserImageToDatabase(imagePath);
            string SQLcommand = $"INSERT INTO [User] VALUES (3,'{name}','{surname}','{username}','{password}','{email}','{city}',{zipcode},'{adress}',{idImage});";
            DataBaseI.Instance.Connect();
            DataBaseI.Instance.ExecuteCommand(SQLcommand);
            DataBaseI.Instance.Disconnect();
        }

        private int AddUserImageToDatabase(string imagePath)
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


        public bool CheckPassword(int user_id, string password)
        {
            bool matches = false;
            string SQLcommand = $"SELECT COUNT (id_user) FROM [User] WHERE id_user={user_id} AND password='{password}';";
            DataBaseI.Instance.Connect();
            if (int.Parse(DataBaseI.Instance.GetValue(SQLcommand).ToString()) == 1)
                matches = true;
            DataBaseI.Instance.Disconnect();
            return matches;
        }

        public User GetUser(int user_id)
        {
            User user=new User(0,User_Type.customer,null,null,null,null,null,null,0,null,null);
            string SQLcommand = $"SELECT * FROM [User] WHERE id_user={user_id}";
            List<User> usersHelp = new List<User>();
            DataBaseI.Instance.Connect();
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                int id_user = (int)dataReader["id_user"];
                int type = (int)dataReader["id_user_type"];
                string name = dataReader["name"].ToString();
                string surname = dataReader["surname"].ToString();
                string username = dataReader["username"].ToString();
                string password = dataReader["password"].ToString();
                string email = dataReader["email"].ToString();
                string city = dataReader["city"].ToString();
                int zipcode = (int)dataReader["zipcode"];
                string address = dataReader["address"].ToString();
                int id_image = (int)dataReader["id_image"];

                User_Type user_Type = User_Type.customer;
                if (type == 1)
                    user_Type = User_Type.admin;
                if (type == 2)
                    user_Type = User_Type.worker;

                Image imageH = GetImage(id_image);

                user = new User(id_user, user_Type, name, surname, username, password, email, city, zipcode, address, imageH);
            }
            dataReader.Close();
            DataBaseI.Instance.Disconnect();
            return user;
        }

        private Image GetImage(int id_image)
        {
            byte[] image=null;
            Image imageItem =new Image (0, image);
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


    }
}
