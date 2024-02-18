using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trendyol.Services.Classes
{
    class LogInService
    {

        public bool IsEmail(string login,DBContext dBContext)
        {
            var users = dBContext.Users.ToList();

            foreach (var user in users)
            {
                if (login == user.Email)
                {
                    return true;
                }
            }
            return false;           
        }


        public bool PasswordIsTrue(string password, DBContext dBContext)
        {
            var users = dBContext.Users.ToList();

            foreach (var user in users)
            {
                if (password == user.Password)
                {
                    return true;
                }
            }
            return false;
        }



    }
}
