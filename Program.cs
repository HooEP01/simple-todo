using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! C#");
            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine() ?? "default";

            string u = username[2..5];
            Console.WriteLine("Username is: " + username);

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age is: " + age);

            List<string> todos = [];

            while (true)
            {
                Console.WriteLine("Todo: ");
                string todo = Console.ReadLine() ?? "default";
                todos.Add(todo);

                foreach (string t in todos)
                {
                    Console.WriteLine(t);
                }
                Console.WriteLine("Continue? (y/n): ");
                string cont = Console.ReadLine() ?? "n";
                if (cont == "n")
                {
                    break;
                }
            }
        }
    }
}