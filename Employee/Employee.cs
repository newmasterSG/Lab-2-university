using System;

namespace Employee
{
    public class Employee
    {
        private readonly string name;
        private readonly string secondname;

        public Employee(string name, string secondname)
        {
            this.name = name;
            this.secondname = secondname;
        }

        public void salary()
        {
            int position,experience;
            double salary, tax;
            Console.WriteLine("We have three positions and types of experience");
            Console.WriteLine("Choice position");
            position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choice experience");
            experience = Convert.ToInt32(Console.ReadLine());
            if (position == 1 && experience <= 3)
            {
                Console.WriteLine("You junior programmer");
                salary = ((50002.05 + 78950.61) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Your salary: {salary}");
                Console.WriteLine($"Your tax: {tax}");
            }
            if (position == 2 && experience <= 3)
            {
                Console.WriteLine("You junior graphic designer");
                salary = ((53000 + 23000) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Your salary: {salary}");
                Console.WriteLine($"Your tax: {tax}");
            }
            if (position == 3 && experience >= 10)
            {
                Console.WriteLine("You senior programmer");
                salary = ((52633.74 + 82503.39) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Your salary: {salary}");
                Console.WriteLine($"Your salary: {tax}");
            }

            Console.WriteLine($"You {name} {secondname} and your posiotion {position}.");

        }


        static void Main(string[] args)
        {
            Employee employee = new Employee("Victor", "Dragon");
            employee.salary();
        }
    }
}
