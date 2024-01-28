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

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you favourite pet : ");
            Console.WriteLine(" 1.cat ");
            Console.WriteLine(" 2.Dog ");
            Console.WriteLine(" 3.Rabbit ");
            String petType = Console.ReadLine();
            Console.WriteLine("Hey, You have Choosen "+ petType);
            Console.WriteLine("Enter your pet Name :");
            String petName = Console.ReadLine();
            Console.WriteLine("Welcome, " + petName + "!");
        }
    }
}
