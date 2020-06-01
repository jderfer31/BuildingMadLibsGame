using System;

namespace BuildingMadLibsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity; //Declaring variables

            Console.Write("Enter a color: ");
            color = Console.ReadLine(); //This stores the input from user on Enter a color
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();
            
            Console.WriteLine("Roses are " + color); //Variables are added to statement
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);



            Console.ReadLine();
        }
    }
}
