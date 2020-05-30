using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;


namespace UserSettingsClass
{
    public class User
    {
        public int Id { get; set; }
        public User_Type UserType { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Adress { get; set; }
        public Image UserImage { get; set; }

        /// <summary>
        /// Constructor used for fetching 1 user.
        /// </summary>
        public User(int id, User_Type user_Type, string name, string surname, string username, string password, string email, string city, int zipCode, string adress, Image userImage)
        {
            this.Id = id;
            this.UserType = user_Type;
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.City = city;
            this.ZipCode = zipCode;
            this.Adress = adress;
            this.UserImage = userImage;
        }
        /// <summary>
        /// Constructor used for getting all users, without needing their pictures and passwords.
        /// </summary>
        public User(int id,User_Type user_Type, string name, string surname, string username, string email, string city, int zipCode, string adress)
        {
            this.Id = id;
            this.UserType = user_Type;
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Email = email;
            this.City = city;
            this.ZipCode = zipCode;
            this.Adress = adress;
        }
    }
}
