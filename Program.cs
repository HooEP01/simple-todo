﻿using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Login();

            List<Todo> todos = [];

            if (File.Exists("todos.json"))
            {
                string readJson = File.ReadAllText("todos.json");
                todos = JsonSerializer.Deserialize<List<Todo>>(readJson) ?? [];
            }

            while (true)
            {
                Console.WriteLine("Todo: ");
                string todo = Console.ReadLine() ?? "default";
                Todo item = new(todo);
                todos.Add(item);

                foreach (Todo t in todos)
                {
                    Console.WriteLine(t.Description + " - " + t.Done);
                }
                Console.WriteLine("Continue? (y/n): ");
                string cont = Console.ReadLine() ?? "n";
                if (cont == "n")
                {
                    break;
                }
            }

            string json = JsonSerializer.Serialize(todos);
            File.WriteAllText("todos.json", json);
        }

        static void Login()
        {
            Console.WriteLine("Hello World! C#");
            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine() ?? "default";

            // string u = username[2..5];
            Console.WriteLine("Username is: " + username);

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age is: " + age);
        }
    }
}