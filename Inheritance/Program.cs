using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Bird articuno = new Bird()
            {
                Name = "Articuno",
                Age = 600,
                Legs = 2,
                HasBackBone = true,
                IsWarmBlooded = true,
                Wings = 2,
                Type = "Ice",
                HasFeathers = true,

            };

            Console.WriteLine($"{articuno.Name} is an {articuno.Type} type legendary Pokemon who's {articuno.Age} years old.");
            Console.WriteLine($" it is {articuno.HasBackBone} that he, like other birds, has a backbone and feathers, as well as {articuno.Wings} wings and {articuno.Legs} legs.");
            Console.WriteLine("________________________________________");
            Reptile dragon = new Reptile()
            {
                Name = "Toothless",
                Age = 23,
                Legs = 4,
                HasBackBone = true,
                IsColdBlooded = true,
                HasScales = true,
                Color = "Black",
                Environment = "Berk"
            };
            Console.WriteLine();
            Console.WriteLine($"{dragon.Name} is {dragon.Age} years old, who lives in a land called {dragon.Environment}.");
            Console.WriteLine($"It is {dragon.IsColdBlooded} that, like other reptiles, he's cold blooded, and {dragon.HasScales} that he has scales," +
                $"{dragon.Name} also has {dragon.Legs} legs and {dragon.Color} colored scales.");

        }



    }
}
