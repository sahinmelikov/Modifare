using System.Security.Cryptography.X509Certificates;

namespace Modifire
{
    internal class Program:validator
    {
        static void Main(string[] args)
        {
           

            Person person=new Person();

            person.Username = "Sahin";
            person.Password = "password";       
            person.Name = "name";
            person.Surname = "jnkjn";
            person.Age = 30;
            person.Birthday = 19;
            Console.WriteLine(person.Username);
            Console.WriteLine(person.Password);
            Console.WriteLine(person.Name);

            Console.WriteLine(person.Surname);

            

            Console.WriteLine(person.Age);
            Console.WriteLine(person.Birthday);

        }

    }
}