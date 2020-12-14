using Mess_around.Fluency;
using Mess_around.Fluency.Repository;
using System;

namespace Fluent_Interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var operation = new Operation(new MessAroundRepository());

            //This is the class that utilizes our fluent interface
            var immutableAnimalModel = operation.GetImmutableAnimalModel(12);

            Console.WriteLine($"Our animals name is: {immutableAnimalModel.Name}");
            Console.WriteLine($"Our animals birth date is: {immutableAnimalModel.BirthDate.Year}");
            Console.WriteLine($"Our animals color is: {immutableAnimalModel.Color}");
            Console.WriteLine($"Our animals name is: {immutableAnimalModel.Age}");

            Console.ReadKey();
        }
    }
}