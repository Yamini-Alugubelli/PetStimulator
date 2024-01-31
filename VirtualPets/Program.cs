using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpTutorials
{
    class Program
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }

        public void Pet(string type, string name)
        {
            Type = type;
            Name = name;
            Health = 100;
            Hunger = 50;
            Happiness = 50;
            Console.WriteLine($"Welcome to the world of virtual pets! You have chosen a {Type} named {Name}.");
        }

        public void Interact()
        {
            Console.WriteLine("Main menu");
            Console.WriteLine("1. Feed\n2. Play\n3. Rest\n4. Status\n5. Exit");
            Console.Write("Enter the number corresponding to your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Feed();
                    break;
                case "2":
                    // Play();
                    break;
                case "3":
                    //  Rest();
                    break;
                case "4":
                    //   Console.WriteLine($"{Name} is left alone.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. {Name} is confused.");
                    break;
            }
        }

        public void Feed()
        {

            Hunger = Math.Max(1, Hunger - 2);
            Health = Math.Min(10, Health + 1);
            Console.WriteLine($"{Name} is fed. Hunger decreased, health slightly increased.");
        }
        class stimulator
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Please enter you favourite pet : ");
                Console.WriteLine(" cat ");
                Console.WriteLine(" Dog ");
                Console.WriteLine(" Rabbit ");
                String petType = Console.ReadLine();
                Console.WriteLine("Hey, You have Choosen " + petType);
                Console.WriteLine("Enter your pet Name :");
                String petName = Console.ReadLine();
                Console.WriteLine("Welcome, " + petName + "!");









            }
        }
    }
}
