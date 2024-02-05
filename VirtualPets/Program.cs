namespace CSharpTutorials
{
    class stimulator
    {
        static void Main(string[] args)
        {
            //pet creation
            Console.WriteLine("Please Enter You Favourite Pet : ");
            Console.WriteLine(" 1.cat\n 2.Dog\n 3.Rabbit ");
            Console.Write("Enter The Number Of Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Pet Name :");
            String petName = Console.ReadLine();
            Console.WriteLine("Welcome, " + petName.ToUpper() + "!");
            Pet pet = new Pet(petName, choice);
            //pet care Actions
            while (true)
            {
                Console.WriteLine("Please Select Your Action :");
                //Actions
                Console.WriteLine(" 1. Feed\n 2. Play\n 3. Rest\n 4. Status\n 5. Health Deterioration\n 6. Exit");
                Console.WriteLine("Enter Your Choice  : ");
                string action = Console.ReadLine();
               
                switch (action)
                {
                    case "1":
                        pet.feed();
                        break;
                    case "2":
                        pet.play();
                        break;
                    case "3":
                        pet.rest();
                        break;
                    case "4":
                        pet.status();
                        break;
                    case "5":
                        pet.simulateTimePassing();
                        break;
                    case "6":
                        pet.exit();
                        return;
                    default:
                        Console.WriteLine("Invalid Option. Please Enter a Number Between 1 and 5.");
                        break;

                }
                

            }
        }
    }
}

class Pet
{
    //declare variables
    public string name;
    public int type;
    public int hunger;
    public int happiness;
    public int health;

    //parametrized constructors
    public Pet(string name, int type)
    {
        this.name = name;
        this.type = type;
        this.hunger = 5;// initializing variable hunger
        this.happiness = 5;// initializing variable hapinees
        this.health = 5;// initializing variable health
    }

    //feed action implementation
    public void feed()
    {
        hunger--;
        health++;
        Console.WriteLine($"{name.ToUpper()} has been fed. Hunger decreased, health increased.");
    }
    //play action implementation
    public void play()
    {
        happiness++;
        hunger++;
        Console.WriteLine($"{name.ToUpper()} has played. Happiness increased, hunger increased.");
    }
    //rest action implementation
    public void rest()
    {
        health++;
        happiness--;
        Console.WriteLine($"{name.ToUpper()} has rested. Health increased, happiness decreased.");
    }
    //exit action implementation
    public void exit()
    {
        Console.WriteLine($"Thanks for taking care of {name.ToUpper()}! See you next time!");
    }

    //status action implementation
    public void status()
    {
        Console.WriteLine($"status of {name.ToUpper()}:");
        Console.WriteLine($"Hunger: {hunger}/10");
        Console.WriteLine($"Happiness: {happiness}/10");
        Console.WriteLine($"Health: {health}/10");
    }
    //Health Deterioration action implementation
    public void simulateTimePassing()
    {
        Console.WriteLine($"An hour has passed for {name.ToUpper()}.");

        // Increase hunger and decrease happiness over time
        hunger++;
        happiness--;

        // Check if neglect consequences
        if (hunger > 8 || happiness < 3)
        {
            health--;
            Console.WriteLine($"{name.ToUpper()}'s health has decreased due to neglect.");
        }

        // Implement special messages or events based on the pet's status
        if (hunger > 5)
        {
            Console.WriteLine($"{name.ToUpper()} is refusing to play because they're too hungry.");
        }
    }

    
}


