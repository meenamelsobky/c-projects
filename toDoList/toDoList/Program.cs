using System;
using System.Collections.Generic;

namespace toDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the to-do list program");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list");
                Console.WriteLine("Enter 2 to remove a task from the list");
                Console.WriteLine("Enter 3 to view the task list");
                Console.WriteLine("Enter 'e' to exit the program");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter the task you want to add:");
                        string task = Console.ReadLine();
                        taskList.Add(task);
                        Console.WriteLine("Task added successfully!");
                        break;
                    case "2":
                        Console.WriteLine("Enter the task you want to remove:");
                        string taskToRemove = Console.ReadLine();
                        if (taskList.Remove(taskToRemove))
                        {
                            Console.WriteLine("Task removed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Task not found in the list!");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Task list:");
                        foreach (string t in taskList)
                        {
                            Console.WriteLine("- " + t);
                        }
                        break;
                    case "e":
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid option! Please try again.");
                        break;
                }
            }
        }
    }
}
