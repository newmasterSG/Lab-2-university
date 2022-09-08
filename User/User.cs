using System;

namespace User
{
    public class User
    {
        public string Login { get; set; }

        public string Firstname { get; set; }

        public string Secondname { get; set; }

        public int Age { get; set; }

        public string Date_of_completion { get; set; }
        public void worksheet()
        {
            Console.WriteLine("Create new worksheet");
            Console.WriteLine("Write your login");
            Login = Console.ReadLine();
            Console.WriteLine("Write your name");
            Firstname = Console.ReadLine();
            Console.WriteLine("Write your secondname");
            Secondname = Console.ReadLine();
            Console.Write("Write your age");
            Age = Convert.ToInt32(Console.ReadLine());
            Date_of_completion = DateTime.Now.ToString();
            Console.WriteLine($"Your login {Login} and name {Firstname} {Secondname}, your age is {Age}. Today is {Date_of_completion} ");
        }

        static void Main(string[] args)
        {
            User u = new User();
            u.worksheet();
        }
    }
}
