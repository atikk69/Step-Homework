using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Models;
using Trendyol.Repository;

namespace Trendyol.Services.Classes
{
    class LogInService
    {

        public bool IsEmail(string login,IUserRepository userRepository)
        {
            var users = userRepository.GetAll();

            foreach (var user in users)
            {
                if (login == user.Email)
                {
                    return true;
                }
            }
            return false;           
        }


        public bool PasswordIsTrue(string email ,string password, IUserRepository userRepository)
        {
            var currentUser = userRepository.GetByEmail(email);
            if (BCrypt.Net.BCrypt.Verify(password,currentUser.Password))
            {
                return true;
            }
            
            return false;
        }



    }
}
