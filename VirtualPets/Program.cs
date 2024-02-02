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
    class stimulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you favourite pet : ");
            Console.WriteLine(" 1.cat ");
            Console.WriteLine(" 2.Dog ");
            Console.WriteLine(" 3.Rabbit ");
            Console.Write("Enter the number of your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

  
            Console.WriteLine("Enter your pet Name :");
            String petName = Console.ReadLine();
            Console.WriteLine("Welcome, " + petName + "!");
            while (true)
            {
                Console.WriteLine("Please Select Your Action :");
                //Boolean flag = false;
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Status");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter Your Choice  : ");
                string action = Console.ReadLine();
                Pet pet = new Pet(petName, choice);
                switch (action)
                {
                    case "1":
                        pet.Feed();
                        break;
                    case "2":
                        pet.Play();
                        break;
                    case "3":
                        pet.Rest();
                        break;
                    case "4":
                        pet.CheckStatus();
                        break;
                    case "5":
                        Console.WriteLine("Thanks for playing!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
                        break;

                }
                

            }
        }
    }
}

class Pet
{
    public string Name { get; }
    public string Type { get; }
    public int Hunger { get; private set; } = 5;
    public int Happiness { get; private set; } = 5;
    public int Health { get; private set; } = 5;

    public Pet(string name, int typechoice)
    {
        Name = name;
        switch (typechoice)
        {
            case 1:
                Type = "cat";
                break;
            case 2:
                Type = "dog";
                break;
            case 3:
                Type = "rabbit";
                break;
            case 4:
                Type = "bird";
                break;
            default:
                Type = "unknown";
                break;
        }
    }

    public void Feed()
    {
        Console.WriteLine($"{Name} is being fed.");
        Hunger = Math.Max(Hunger - 2, 0);
        Health = Math.Min(Health + 1, 10);
    }

    public void Play()
    {
        Console.WriteLine($"{Name} is playing.");
        Happiness = Math.Min(Happiness + 2, 10);
        Hunger = Math.Min(Hunger + 1, 10);
    }

    public void Rest()
    {
        Console.WriteLine($"{Name} is resting.");
        Health = Math.Min(Health + 2, 10);
        Happiness = Math.Max(Happiness - 1, 0);
    }

    public void CheckStatus()
    {
        Console.WriteLine($"Current status of {Name}:");
        Console.WriteLine($"Hunger: {Hunger}/10");
        Console.WriteLine($"Happiness: {Happiness}/10");
        Console.WriteLine($"Health: {Health}/10");
    }
}


