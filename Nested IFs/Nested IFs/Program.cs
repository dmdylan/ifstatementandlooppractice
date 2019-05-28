using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_IFs
{
    class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
 
        }

        public static void Register()
        {
            Console.WriteLine("Please enter a username to register:");
            username = Console.ReadLine();
            Console.WriteLine("Your username is {0}", username);
            Console.WriteLine("Please enter a password:");
            password = Console.ReadLine();
            Console.WriteLine("Your password is {0}", password);

        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username to login:");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Enter your password:");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login Successful");
                }
                else
                {
                    Console.WriteLine("Wrong password, please restart the program");
                }
            }
            else
            {
                Console.WriteLine("Wrong username, please restart the program");
            }

        }
    }
}
