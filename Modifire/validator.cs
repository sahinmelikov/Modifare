using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifire
{
    internal class validator:Person
    {
        public string ValidateUsername(string Username)
        {

            if (Username.Length >= 2)
            {
                return Username;
            }
            return "error";
            

        }
        public bool ValidateName(string Name)
        {
            if (Name.Length <= 2)
            {
                Console.WriteLine("include your name properly");
            }
            return true;

        }

        public bool ValidateSurname(string Surname)
        {
            if (Surname.Length <= 2)
            {
                Console.WriteLine("include your Surname properly");
            }
            return true;

        }
        public bool ValidatePassword(string Password)
        {
            if (Password.Length < 8)

            {
                Console.WriteLine("include your Password properly");

            }
            return true;
        }
        public bool ValidateAge(int Age)
        {
            if (Age < 0)
            {
                Console.WriteLine("include your Age properly");
            }
            return true;
        }
        public bool ValidateBirthday(int Birthday)
        {
            if (Birthday < 1970)
            {
                Console.WriteLine("Error");
            }
            return true;

        }
    }
}
