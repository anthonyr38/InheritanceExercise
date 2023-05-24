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
            var avian1 = new Bird();

            avian1.WingColor = "blue";
            avian1.CanFly = true;
            avian1.DoMigrate = true;
            avian1.BeakLength = 5;

            Console.WriteLine($"This beautiful bird has dark {avian1.WingColor} wings. " +
                $"It is {avian1.CanFly} that this critter can fly because it is {avian1.DoMigrate} that this animal migrates. " +
                $"It has a beak length of {avian1.BeakLength} that it uses to catch fish. \n");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var rept1 = new Reptile()
            {
                ColdBlooded = true,
                Scaley = true,
                Continent = "North America",
                Regenerate = true,   
            };

            Console.WriteLine($"This creature likes to bask in the sun because it is {rept1.ColdBlooded} that it is cold blooded. " +
                $"It is {rept1.Scaley} that this critter fells odd to the touch because it is scaley." +
                $"It has usually found in the western parts of {rept1.Continent}. It is also {rept1.Regenerate} that this creature " +
                $"can regrow some of its body parts. \n");


            var CritterArray = new Animal[] { avian1, rept1 };

            foreach ( var critter in CritterArray) 
            {
                Console.WriteLine($"{critter} \n ");

                

                Console.WriteLine($"Is not extinct:{critter.IsItAlive}");
                Console.WriteLine($"Is {critter.Age} years old");
                Console.WriteLine($"Has {critter.Legs} legs");
                Console.WriteLine($"It lives in the {critter.Habitat} \n ");
            }

        }
    }
}
