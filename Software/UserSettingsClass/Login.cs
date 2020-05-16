using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSettingsClass
{
    public class Login
    {
        UserRepository userRepository;
        public object UserLogin(string usernameEmail, string password)
        {
            string message = "Sucess!";
            message=CheckEmpty(usernameEmail, password);
            if (message != "")
                return message;
            int user_id = CheckUsernameEmailExists(usernameEmail);
            if(user_id==0)
                return "This username/email does not exist. Please check you username/email field!";
            message = CheckPasswordMatch(user_id, password);
            if (message != "")
                return message;
            else
            {
                userRepository = new UserRepository();
                return userRepository.GetUser(user_id);
            }
        }

        

        private string CheckEmpty(string usernameEmail, string password)
        {
            if (usernameEmail == "")
                return "Identification (username/email) field is empty. Please fill it before proceding!";
            if (password == "")
                return "Password field is empty. Please fill it before proceding!";
            return "";
        }

        private int CheckUsernameEmailExists(string usernameEmail)
        {
            int user_id = 0;
            userRepository = new UserRepository();
            user_id = userRepository.CheckIfUsernameExists(usernameEmail);
            if (user_id==0)
                user_id = userRepository.CheckIfEmailExists(usernameEmail);
            return user_id;
        }

        private string CheckPasswordMatch(int user_id, string password)
        {
            userRepository = new UserRepository();
            bool match = userRepository.CheckPassword(user_id, password);
            if (!match)
                return "You entered wrong password! Please check CAPSLOCK and try again!";
            else
                return "";
        }

        
    }
}
