using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace UserSettingsClass
{
    public class Register
    {
        UserRepository userRepository;
        public MemoryStream GetDefaultImage()
        {
            DataBaseI.Instance.Connect();
            byte[] image = null;
            string SQLcommand = "SELECT image FROM [Image] WHERE id_image=1;";
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                image = (byte[])dataReader["image"];
            }
            dataReader.Close();
            DataBaseI.Instance.Disconnect();
            MemoryStream msImage = new MemoryStream(image);
            return msImage;
        }


        public string AddNewUser(string name, string surname, string username, string password, string repeatPassword, string email, string city, int zipcode, string adress, string imagePath)
        {
            string check = CheckIfEmpty(username, email, password, repeatPassword, name, surname);
            if (check != "")
                return check;
            check = CheckIfEmailFormCorrect(email);
            if (check != "")
                return check;
            check = CheckIfPasswordMatch(password, repeatPassword);
            if (check != "")
                return check;
            userRepository = new UserRepository();
            int user_id = userRepository.CheckIfUsernameExists(username);
            if (user_id!=0)
                return "This username is already in use. Please use another one!";
            user_id = userRepository.CheckIfEmailExists(email);
            if (user_id!=0)
                return "This email is already in use. Please use another one!";
            userRepository.AddNewUserToDatabase(name, surname, username, password, email, city, zipcode, adress, imagePath);
            return "Success! You have successfully made an account for Custom Pizza!";
        }

        private string CheckIfEmpty(string username, string email, string password, string repeatPassword, string name, string surname)
        {
            if (username == "")
                return "Username is a necessary field. Please enter it!";
            if (email == "")
                return "Email is a necessary field. Please enter it!";
            if (password == "")
                return "Password is a necessary field. Please enter it!";
            if (repeatPassword == "")
                return "Repeat password is a necessary field. Please enter it!";
            if (name == "")
                return "Name is a necessary field. Please enter it!";
            if (surname == "")
                return "Surname is a necessary field. Please enter it!";
            return "";
        }

        private string CheckIfEmailFormCorrect(string email)
        {
            if (!email.Contains('@'))
                return "Please enter correct form for email!";
            return "";
        }

        private string CheckIfPasswordMatch(string password, string repeatPassword)
        {
            if (password != repeatPassword)
                return "Passwords don't match. Please make sure to enter the same passwords!";
            return "";
        }

        private int AddImage()
        {
            return 1;
        }
    }
}
