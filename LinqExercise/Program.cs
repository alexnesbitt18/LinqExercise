using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            //TODO: Print the Sum of numbers
            var sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");

            //TODO: Print the Average of numbers
            var average = numbers.Average();
            Console.WriteLine($"Average: {average}");

            //TODO: Order numbers in ascending order and print to the console
            var ascending = numbers.OrderBy(num => num);
            Console.WriteLine($"------------");
            Console.WriteLine($"Ascending:");
            foreach(var num in ascending)
            {
                Console.WriteLine($"{num}");
            }

            //TODO: Order numbers in descending order and print to the console
            var descending = numbers.OrderByDescending(num => num);
            Console.WriteLine($"------------");
            Console.WriteLine($"Descending:");
            foreach (var num in descending)
            {
                Console.WriteLine($"{num}");
            }
            //TODO: Print to the console only the numbers greater than 6
            var sixorgreater = numbers.Where(num => num > 6).OrderBy(num => num);
            Console.WriteLine($"------------");
            Console.WriteLine($"Numbers Greater than Six:");
            foreach (var num in sixorgreater)
            {
                Console.WriteLine($"{num}");
            }
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var printfour = ascending.Take(4);
            Console.WriteLine($"Ascending First 4:");
            foreach (var num in printfour)
            {
                Console.WriteLine($"{num}");
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 30;
            foreach(var item in numbers.OrderByDescending(num => num))
            {
                Console.WriteLine($"{item}");
            }
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var fullname = employees.Where(person => person.FirstName.StartsWith('C') || person.FirstName.StartsWith('S')).OrderBy(person => person.FirstName);
            Console.WriteLine($"Employees with 'C' and 'S' names:");
            foreach(var employee in fullname)
            {
                Console.WriteLine(employee.FullName);
            }
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var variable = employees.Where(person => person.Age > 26).OrderBy(person => person.Age).ThenBy(person => person.FirstName);
            Console.WriteLine($"Employees ordered by age and then first name:");
            foreach (var person in variable)
            {
                Console.WriteLine($"Age: {person.Age} , Full Name: {person.FullName}");
            }

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var yearsofexperience = employees.Where(person => person.YearsOfExperience <= 10 && person.Age > 35);
            var sumyearsofexperience = yearsofexperience.Sum(person => person.YearsOfExperience);
            var averageyearofage = yearsofexperience.Average(person => person.Age);

            Console.WriteLine($"Employees ordered by Years of Experience and then by Age:");
            Console.WriteLine($"Sum: {sumyearsofexperience} , Avg: {averageyearofage}");

            //TODO: Add an employee to the end of the list without using employees.Add()
            employees.Append(new Employee("first" , "lastName" , 98, 10)).ToList();


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
